using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa21team16finalproject.DAL;
using fa21team16finalproject.Models;

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
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reviews.ToListAsync());
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
                            .FirstOrDefaultAsync(m => m.PropertyID == SelectedProperty);

            var dbCustomer = await _context.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);

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
                       
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            ViewBag.AllProperties = GetAllPropertiesAvailable();
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
                return RedirectToAction(nameof(Index));
            }
            return View(review);
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
