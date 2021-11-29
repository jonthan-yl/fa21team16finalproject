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
    public class ReservationsController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index(int? orderID)
        {
            if (orderID == null)
            {
                return View("Error", new String[] { "Please specify an order to view!" });
            }

            //limit the list to only the registration details that belong to this registration
            List<Reservation> ods = await _context.Reservations
                                          .Include(r => r.Property)
                                          .Include(r => r.Order)
                                          .ThenInclude(r => r.AppUser)
                                          .Where(r => r.Order.OrderID == orderID)
                                          .ToListAsync();

            return View(ods);
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.ReservationID == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create(int orderID)
        {       
            Reservation reservation = new Reservation();

            reservation.Order = _context.Orders.Find(orderID);
            //_context.SaveChangesAsync();

            ViewBag.AllProperties = GetAllPropertiesAvailable();

            return View(reservation);
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservationID,CheckInDate,CheckOutDate," +
                                                    "TotalDays,WeekNightPrice,WeekendNightPrice,ExtendedPrice," +
                                                    " CleaningFee, Order")] 
                                                     Reservation reservation, int SelectedProperty)
        {
            ViewBag.AllProperties = GetAllPropertiesAvailable();
            if (ModelState.IsValid == false)
            {
                return View(reservation);
            }

            if (reservation.CheckInDate < DateTime.Now)
            {
                ViewBag.ErrorMessage = "Check in date cannot be prior to today's date";
                return View(reservation);
            }
            if (reservation.CheckOutDate < reservation.CheckInDate)
            {
                ViewBag.ErrorMessage = "Check in date must be prior to check out date";
                return View(reservation);
            }


            Property dbProperty = await _context.Properties.Include(p => p.Reservations)
                                    .FirstOrDefaultAsync(p =>p.PropertyID == SelectedProperty);

            Order dbOrder = await _context.Orders.Include(o => o.Reservations)
                                    .FirstOrDefaultAsync(o => o.OrderID == reservation.Order.OrderID);
            AppUser dbCustomer =  _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            reservation.Customer = dbCustomer;
            reservation.Order = dbOrder;
            reservation.Property = dbProperty;
            reservation.WeekendNightPrice = dbProperty.WeekendNightPrice;
            reservation.WeekNightPrice = dbProperty.WeekNightPrice;
            reservation.CleaningFee = dbProperty.CleaningFee;
            reservation.DiscountDays = dbProperty.DiscountDays;
            reservation.PercentDiscount = dbProperty.PercentDiscount;

            if (!(dbProperty.DiscountDays == 0 | dbProperty.PercentDiscount == null))
            {
                reservation.PercentDiscount = dbProperty.PercentDiscount;
            }
            foreach (Reservation currentRsv in reservation.Property.Reservations)
            {
                 if (currentRsv.CheckInDate.CompareTo(reservation.CheckInDate) < 0 & 
                    currentRsv.CheckOutDate.CompareTo(reservation.CheckInDate) > 0) 
                    {
                    string Err = "This reservation time conflicts with a previously held reservation of "
                        + currentRsv.CheckInDate + " to " + currentRsv.CheckOutDate;
                        ViewBag.ErrorMessage = Err;
                        return View(reservation);
                    }
            }
            foreach(Reservation currentRsv in reservation.Order.Reservations)
            {
                if (currentRsv.CheckInDate.CompareTo(reservation.CheckInDate) < 0 &
                   currentRsv.CheckOutDate.CompareTo(reservation.CheckInDate) > 0)
                {
                    string Err = "This reservation time conflicts with your reservation at "
                        + currentRsv.Property.Street + " from " 
                        + currentRsv.CheckInDate + " to " + currentRsv.CheckOutDate;
                    ViewBag.ErrorMessage = Err;
                    return View(reservation);
                }

            }

            reservation.CalcExtendedPrice();
            //Adds the reservation to the order's reservations list
            dbOrder.Reservations.Add(reservation);
            dbProperty.Reservations.Add(reservation);

            _context.Add(reservation);
            await _context.SaveChangesAsync();
            ViewBag.AllProducts = GetAllPropertiesAvailable();
            return RedirectToAction("Index", "Orders");
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.AllProperties = GetAllPropertiesAvailable();
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservationID,CheckInDate,CheckOutDate," +
                                                    "TotalDays,WeekNightPrice,WeekendNightPrice,ExtendedPrice," +
                                                    " CleaningFee, Order")]
                                                     Reservation @reservation, int SelectedProperty)
        {
            if (id != @reservation.ReservationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (@reservation.CheckInDate < DateTime.Now)
                {
                    ViewBag.ErrorMessage = "Check in date cannot be prior to today's date";
                    return View(reservation);
                }
                if (@reservation.CheckOutDate < @reservation.CheckInDate)
                {
                    ViewBag.ErrorMessage = "Check in date must be prior to check out date";
                    return View(@reservation);
                }

                ViewBag.AllCategories = GetAllPropertiesAvailable();
                foreach (Reservation currentRsv in @reservation.Property.Reservations)
                {
                    if (currentRsv.CheckInDate.CompareTo(@reservation.CheckInDate) < 0 &
                       currentRsv.CheckOutDate.CompareTo(@reservation.CheckInDate) > 0)
                    {
                        string Err = "This reservation time conflicts with a previously held reservation of "
                            + currentRsv.CheckInDate + " to " + currentRsv.CheckOutDate;
                        ViewBag.ErrorMessage = Err;
                        return View(@reservation);
                    }
                }
                foreach (Reservation currentRsv in @reservation.Order.Reservations)
                {
                    if (currentRsv.CheckInDate.CompareTo(@reservation.CheckInDate) < 0 &
                       currentRsv.CheckOutDate.CompareTo(@reservation.CheckInDate) > 0)
                    {
                        string Err = "This reservation time conflicts with your reservation at "
                            + currentRsv.Property.Street + " from "
                            + currentRsv.CheckInDate + " to " + currentRsv.CheckOutDate;
                        ViewBag.ErrorMessage = Err;
                        return View(@reservation);
                    }

                }

                @reservation.CalcExtendedPrice();
                await _context.SaveChangesAsync();

                try
                {
                    _context.Update(@reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.ReservationID))
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
            return View(@reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.ReservationID == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ReservationID == id);
        }
    }
}
