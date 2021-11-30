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
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders
                .Include(o => o.Reservations)
                .Where(o => o.AppUser.UserName == User.Identity.Name)
                .ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            var order  = await _context.Orders.Include(o => o.Reservations)
                                              .ThenInclude(o => o.Property)
                                              .Include(o => o.AppUser)
                        .FirstOrDefaultAsync(o => o.AppUser.UserName == User.Identity.Name && o.Status == Status.Pending);
            if (order == null)
            {
                return NotFound();
            }
            if (User.IsInRole("Customer") && order.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order!  Don't be such a snoop!" });
            }
            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,ConfirmationNumber,OrderDate")] Order order)
        {
            order.OrderDate = DateTime.Now;

            order.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "Reservations", new { orderID = order.OrderID });
            }
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                                        .Include(o => o.Reservations)
                                        .ThenInclude(o => o.Property)
                                        .Include(o => o.AppUser)
                                        .FirstOrDefaultAsync(m => m.OrderID == id);

            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,ConfirmationNumber,OrderDate")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
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
            return View(order);
        }

        public async Task<IActionResult> ConfirmOrder(int orderId)
        {
            var order = await _context.Orders
                .Include(o => o.AppUser)
                .Include(o => o.Reservations)
                .ThenInclude(o => o.Property)
                .FirstOrDefaultAsync(m => m.OrderID == orderId);

            if (order.Status == Status.Confirmed)
            {
                return View("Error", new String[] { "This order has already been confirmed" });
            }

            if (order.Status == Status.Cancelled)
            {
                return View("Error", new String[] { "This order has already been cancelled" });
            }

            if (User.IsInRole("Customer") && order.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order!  Don't be such a snoop!" });
            }

            if (order.Reservations.Count == 0)
            {
                ViewBag.ErrorMessage = "You have not yet added any reservations to your order!";
                return View("Details", order);
            }
            order.Status = Status.Confirmed;
            order.ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(_context);
            _context.Update(order);
            await _context.SaveChangesAsync();
            return View(order);
        }

        public async Task<IActionResult> ConfirmationScreen (int orderId)
        {
            var order = await _context.Orders
               .Include(o => o.AppUser)
                 .Include(o => o.Reservations)
                .ThenInclude(o => o.Property)
                 .FirstOrDefaultAsync(m => m.OrderID == orderId);

            return View(order);
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }
    }
}
