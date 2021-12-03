using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa21team16finalproject.DAL;
using fa21team16finalproject.Models;
using Microsoft.AspNetCore.Authorization;

namespace fa21team16finalproject.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _context;

        public ReviewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reviews
        public async Task<IActionResult> Index(int? PropertyID)
        {

            List<Property> properties = _context.Properties.Include(p => p.Reviews).ThenInclude(p => p.Property).ToList();

            foreach (Property property in properties)
            {
                if (property.Reviews.Count() != 0)
                {
                    property.Rating = (decimal)property.Reviews.Where(r => r.Disputed == false).Average(r => r.Rating);
                    _context.Update(property);
                    await _context.SaveChangesAsync();
                }
            }

            if (PropertyID != null)
            {
                if (User.IsInRole("Host"))
                {
                    List<Review> revs = await _context.Reviews
                            .Include(r => r.Property)
                            .ThenInclude(r => r.Host)
                            .Include(r => r.Customer)
                            .Where(r => r.Property.Host.UserName == User.Identity.Name)
                            .ToListAsync();

                    return View(revs);
                }
                List<Review> reviews = await _context.Reviews
                                        .Include(r => r.Property)
                                        .Include(r => r.Customer)
                                        .Where(r => r.Property.PropertyID == PropertyID)
                                        .ToListAsync();
                return View(reviews);
            }
            else
            {
                List<Review> revi = await _context.Reviews
                            .Include(r => r.Property)
                            .ThenInclude(r => r.Host)
                            .Include(r => r.Customer)
                            .ToListAsync();
                return View(revi);
            }
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Reviews/Create
        public IActionResult Create()
        {
            ViewBag.AllProperties = GetAllPropertiesAvailable();
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewID,Rating,Comments")] Review review, int SelectedProperty)
        {
            var dbProperty = await _context.Properties
                            .Include(p => p.Reservations)
                            .ThenInclude(r => r.Customer)
                            .Include(p => p.Reviews)
                            .ThenInclude(r => r.Customer)
                            .FirstOrDefaultAsync(m => m.PropertyID == SelectedProperty);

            var dbCustomer = await _context.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);

            ViewBag.AllProperties = GetAllPropertiesAvailable();

            foreach (Review rvw in dbProperty.Reviews)
            {
                if (rvw.Customer.UserName == User.Identity.Name)
                {
                    ViewBag.ErrorMessage = "Our database indicates you have already made a review for this property";
                    return View(review);
                }
            }

            foreach (Reservation currentRsv in dbProperty.Reservations)
            {
                if ((currentRsv.Customer.UserName == User.Identity.Name) & (currentRsv.CheckInDate.CompareTo(DateTime.Now) < 0))
                {
                    if (ModelState.IsValid)
                    {
                        review.Customer = dbCustomer;
                        review.Property = dbProperty;
                        dbProperty.Reviews.Add(review);
                        dbCustomer.Reviews.Add(review);
                        dbProperty.calcRating();
                        _context.Add(review);
                        await _context.SaveChangesAsync();
                        List<Property> properties = _context.Properties.Include(p => p.Reviews).ThenInclude(p => p.Property).ToList();

                        foreach (Property property in properties)
                        {
                            if (property.Reviews.Count() != 0)
                            {
                                property.Rating = (decimal)property.Reviews.Where(r => r.Disputed == false).Average(r => r.Rating);
                                _context.Update(property);
                                await _context.SaveChangesAsync();
                            }
                        }
                        return RedirectToAction(nameof(Index));
                    }
                }
            }

            ViewBag.ErrorMessage = "Our database indicates you have not yet stayed at this property";
            return View(review);
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,Rating,Comments")] Review review)
        {
            if (id != review.ReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.ReviewID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                List<Property> properties = _context.Properties.Include(p => p.Reviews).ThenInclude(p => p.Property).ToList();

                foreach (Property property in properties)
                {
                    if (property.Reviews.Count() != 0)
                    {
                        property.Rating = (decimal)property.Reviews.Where(r => r.Disputed == false).Average(r => r.Rating);
                        _context.Update(property);
                        await _context.SaveChangesAsync();
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }

        [Authorize(Roles = "Host")]
        public async Task<IActionResult> DisputeReview(int? id)
        {
            var review = await _context.Reviews.FindAsync(id);
            review.Disputed = true;
            _context.Update(review);
            List<Property> properties = _context.Properties.Include(p => p.Reviews).ThenInclude(p => p.Property).ToList();

            foreach (Property property in properties)
            {
                if (property.Reviews.Count() != 0)
                {
                    property.Rating = (decimal)property.Reviews.Where(r => r.Disputed == false).Average(r => r.Rating);
                    _context.Update(property);
                    await _context.SaveChangesAsync();
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DisputedReviews()
        {
            var reviews = await _context.Reviews
                         .Include(r => r.Customer)
                         .Include(r => r.Property)
                         .Where(r => r.Disputed == true)
                         .ToListAsync();

            return View(reviews);
        }

        // POST: Properties/Disable/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApproveReview(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            review.Disputed = false;
            _context.Update(review);
            List<Property> properties = _context.Properties.Include(p => p.Reviews).ThenInclude(p => p.Property).ToList();

            foreach (Property property in properties)
            {
                if (property.Reviews.Count() != 0)
                {
                    property.Rating = (decimal)property.Reviews.Where(r => r.Disputed == false).Average(r => r.Rating);
                    _context.Update(property);
                    await _context.SaveChangesAsync();
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
            List<Property> properties = _context.Properties.Include(p => p.Reviews).ThenInclude(p => p.Property).ToList();

            foreach (Property property in properties)
            {
                if (property.Reviews.Count() != 0)
                {
                    property.Rating = (decimal)property.Reviews.Where(r => r.Disputed == false).Average(r => r.Rating);
                    _context.Update(property);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.ReviewID == id);
        }
        private SelectList GetAllPropertiesAvailable()
        {
            List<Property> allProperties = _context.Properties.
                Include(p => p.Host).Include(p => p.Reviews).
                Where(p => p.isPending != true).
                Where(p => p.isDisabled != true).ToList();


            SelectList slAllProperties = new SelectList(allProperties,
               "PropertyID", "Street");

            return slAllProperties;
        }
    }
}
