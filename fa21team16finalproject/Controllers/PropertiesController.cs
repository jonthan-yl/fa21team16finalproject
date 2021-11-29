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
    public class PropertiesController : Controller
    {
        private readonly AppDbContext _context;

        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            List<Property> properties;
            if (User.IsInRole("Host"))
            {
                properties = await _context.Properties
                            .Include(p => p.Host)
                            .Include(p => p.Reviews)
                            .Include(p => p.Category)
                            .Where(p => p.Host.UserName == User.Identity.Name)
                            .Where(p => p.isDisabled == false)
                            .ToListAsync();
            }
            else
            {
                properties = await _context.Properties
                             .Include(p => p.Host)
                             .Include(p => p.Reviews)
                             .Include(p => p.Category)
                             .Where(p => p.isDisabled == false)
                             .Where(p => p.isPending == false)
                             .ToListAsync();
            }
            return View(properties);
        }

        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties
                .FirstOrDefaultAsync(m => m.PropertyID == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // GET: Properties/Create
        public IActionResult Create()
        {
            ViewBag.AllCategories = GetAllCategories(false);
            return View();
        }

        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyID,Street,City,State,ZipCode,CleaningFee,WeekNightPrice,WeekendNightPrice,NumberOfBedrooms,NumberOfBathrooms,PetsAllowed,FreeParking,GuestLimit,Discount,DiscountDays,PercentDiscount, PropertyNumber")] Property property, int SelectedCategory)
        {
            ViewBag.AllCategories = GetAllCategories(false);

            property.PropertyNumber = Utilities.GenerateNextPropertyNumber.GetNextPropertyNumber(_context);
            AppUser dbHost = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            property.Host = dbHost;

            Category dbCategory = _context.Categories.Find(SelectedCategory);
            property.Category = dbCategory;

            property.isPending = true;

            if (ModelState.IsValid == true) {
                _context.Add(property);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(property);
        }

        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.AllCategories = GetAllCategories(false);
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }
            return View(@property);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyID,Street,City,State,ZipCode,CleaningFee,WeekNightPrice,WeekendNightPrice,Discount,DiscountDays,PercentDiscount")] Property @property)
        {
            if (id != @property.PropertyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                ViewBag.AllCategories = GetAllCategories(false);
                try
                {
                    _context.Update(@property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyExists(@property.PropertyID))
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
            return View(@property);
        }

        // GET: Properties/Disable/5
        [Authorize(Roles = "Host")]
        public async Task<IActionResult> Disable(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var property = await _context.Properties
                                        .Include(p => p.Host)
                                        .FirstOrDefaultAsync(m => m.PropertyID == id);

            if (property.Host.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your property!" });
            }

            if (property == null)
            {
                return NotFound();
            }

            return View(property);
        }

        // POST: Properties/Disable/5
        [HttpPost, ActionName("Disable")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DisableConfirmed(int id)
        {
            var property = await _context.Properties.FindAsync(id);
            property.isDisabled = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PendingProperties()
        {
            var properties = await _context.Properties
                         .Include(p => p.Host)
                         .Include(p => p.Reviews)
                         .Include(p => p.Category)
                         .Where(p => p.isDisabled == false)
                         .Where(p => p.isPending == true)
                         .ToListAsync();

            return View(properties);
        }

        // POST: Properties/Disable/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApproveProperty(int id)
        {
            var property = await _context.Properties.FindAsync(id);
            property.isPending = false;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult PropertySearch()
        {
            ViewBag.AllCategories = GetAllCategories(true);
            return View();
        }

        public ActionResult DisplaySearchResults(SearchViewModels svm)
        {
            ViewBag.AllCategories = GetAllCategories(true);

            var query = from p in _context.Properties.Include(p => p.Host)
                             .Include(p => p.Reviews)
                             .Include(p => p.Category)
                             .Where(p => p.isDisabled == false)
                             .Where(p => p.isPending == false)
                        select p;

            if (svm.SearchState != null) //user entered something
            {
                query = query.Where(p => p.State == svm.SearchState);
            }
            if (svm.SearchCity != null) //user entered something
            {
                query = query.Where(p => p.City.Contains(svm.SearchCity));
            }
            if (svm.SearchGuests != null) //user entered something
            {
                query = query.Where(p => p.GuestLimit >= svm.SearchGuests);
            }
            if (svm.SearchWeekPrice != null) //user entered something
            {
                query = query.Where(p => p.WeekNightPrice <= svm.SearchWeekPrice);
            }
            if (svm.SearchWeekendPrice != null) //user entered something
            {
                query = query.Where(p => p.WeekendNightPrice <= svm.SearchWeekendPrice);
            }
            if (svm.SearchCategory.CategoryID != 0)
            {
                query = query.Where(p => p.Category.CategoryID == svm.SearchCategory.CategoryID);
            }
            if (svm.SearchBedrooms != null)
            {
                query = query.Where(p => p.NumberOfBedrooms >= svm.SearchBedrooms);
            }
            if (svm.SearchBathrooms != null)
            {
                query = query.Where(p => p.NumberOfBathrooms >= svm.SearchBathrooms);
            }
            if (svm.SearchPets == true)
            {
                query = query.Where(p => p.PetsAllowed == svm.SearchPets);
            }
            if (svm.SearchParking == true)
            {
                query = query.Where(p => p.FreeParking == svm.SearchParking);
            }

            List<Property> properties = query.ToList();

            ViewBag.AllProperties = _context.Properties
                                    .Where(p => p.isDisabled == false)
                                    .Where(p => p.isPending == false).Count();
            ViewBag.SelectedProperties = properties.Count();

            return View("Index", properties.OrderBy(p => p.State));
        }

        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyID == id);
        }
        private SelectList GetAllCategories(bool search)
        {
            //Get the list of months from the database
            List<Category> categoryList = _context.Categories.ToList();

            if (search == true)
            {
                Category SelectNone = new Category() { CategoryID = 0, Name = "All Categories" };
                categoryList.Add(SelectNone);
            }

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList categorySelectList = new SelectList(categoryList.OrderBy(m => m.CategoryID), "CategoryID", "Name");

            //return the SelectList
            return categorySelectList;
        }

    }
}
