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
    public class ReservationsController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            //limit the list to only the registration details that belong to this registration

        if (User.IsInRole("Customer"))
            {
                List<Reservation> ods = await _context.Reservations
                    .Include(r => r.Property)
                    .Include(r => r.Order)
                    .ThenInclude(r => r.AppUser)
                    .Where(r => r.Customer.UserName == User.Identity.Name)
                    .ToListAsync();
                return View(ods);
            }
        else if (User.IsInRole("Host"))
            {
                List<Reservation> ods = await _context.Reservations
                  .Include(r => r.Property)
                  .Include(r => r.Order)
                    .ThenInclude(r => r.AppUser)
                   .Where(r => r.Property.Host.UserName == User.Identity.Name)
                   .ToListAsync();
                return View(ods);
            }
            else
            {
                List<Reservation> ods = await _context.Reservations
                    .Include(r => r.Property)
                    .Include(r => r.Order)
                    .ThenInclude(r => r.AppUser)
                    .ToListAsync();
                return View(ods);
            }
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(m => m.Property)
                .Include(m => m.Customer)
                .FirstOrDefaultAsync(m => m.ReservationID == id);

           if (User.IsInRole("Customer") && reservation.Customer.UserName != User.Identity.Name)
                {
                    return View("Error", new String[] { "This is not your order!  Don't be such a snoop!" });
                }

            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {       
            Reservation reservation = new Reservation();

            _context.SaveChangesAsync();
            if (User.IsInRole("Host"))
            {
                List<Property> allProperties = _context.Properties.
                    Include(p => p.Host).Include(p => p.Reviews).
                    Where(p => p.isPending != true).
                    Where(p => p.isDisabled != true).
                    Where(p => p.Host.UserName == User.Identity.Name).ToList();

                SelectList slAllProperties = new SelectList(allProperties,
                   "PropertyID", "Street");

                ViewBag.AllProperties = slAllProperties;

            }
            else
            {
                ViewBag.AllProperties = GetAllPropertiesAvailable();
            }

            return View(reservation);
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservationID,CheckInDate,CheckOutDate," +
                                                    "TotalDays,WeekNightPrice,WeekendNightPrice,ExtendedPrice," +
                                                    " CleaningFee")] 
                                                     Reservation reservation, int SelectedProperty)
        {
            ViewBag.AllProperties = GetAllPropertiesAvailable();
            Order dbOrder = await _context.Orders.Include(o => o.Reservations)
                        .FirstOrDefaultAsync(o => o.AppUser.UserName == User.Identity.Name && o.Status == Status.Pending);

            if (dbOrder == null)
            {
                var order = new Order();
                order.Status = Status.Pending;
                order.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                _context.Add(order);
                reservation.Order = order;
                await _context.SaveChangesAsync();
            }

            if (ModelState.IsValid == false)
            {
                return View(reservation);
            }
            /* TODO: REMOVE COMMENT 
            if (reservation.CheckInDate < DateTime.Now)
            {
                ViewBag.ErrorMessage = "Check in date cannot be prior to today's date";
                return View(reservation);
            }
            */
            if (reservation.CheckOutDate < reservation.CheckInDate)
            {
                ViewBag.ErrorMessage = "Check in date must be prior to check out date";
                return View(reservation);
            }


            Property dbProperty = await _context.Properties.Include(p => p.Reservations)
                                    .FirstOrDefaultAsync(p =>p.PropertyID == SelectedProperty);


            //This SHOULD always return a dbOrder now
            dbOrder = await _context.Orders.Include(o => o.Reservations)
                        .FirstOrDefaultAsync(o => o.AppUser.UserName == User.Identity.Name && o.Status == Status.Pending);

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
            if (!User.IsInRole("Host"))
            {
                foreach (Reservation currentRsv in reservation.Property.Reservations)
                {
                    string Err = "This reservation time conflicts with a previously held reservation of "
                             + currentRsv.Property.Street + " from "
                             + currentRsv.CheckInDate + " to " + currentRsv.CheckOutDate;
                    if (datesConflict(currentRsv.CheckInDate, currentRsv.CheckOutDate, reservation.CheckInDate, reservation.CheckOutDate))
                    {
                        ViewBag.ErrorMessage = Err;
                        return View(reservation);
                    }
                }
                foreach (Reservation currentRsv in reservation.Order.Reservations)
                {
                    string Err = "This reservation time conflicts with a reservation on this order at "
                          + currentRsv.Property.Street + " from "
                          + currentRsv.CheckInDate + " to " + currentRsv.CheckOutDate;
                    if (datesConflict(currentRsv.CheckInDate, currentRsv.CheckOutDate, reservation.CheckInDate, reservation.CheckOutDate))
                    {
                        ViewBag.ErrorMessage = Err;
                        return View(reservation);
                    }

                }

                reservation.CalcExtendedPrice();
                reservation.Status = Status.Pending;
            }
            else
            {
                reservation.Status = Status.Confirmed;
            }
            //Adds the reservation to the order's reservations list
            dbOrder.Reservations.Add(reservation);
            dbProperty.Reservations.Add(reservation);
            

            _context.Add(reservation);
            await _context.SaveChangesAsync();
            ViewBag.AllProducts = GetAllPropertiesAvailable();
            List<Reservation> ods = await _context.Reservations
                    .Include(r => r.Property)
                    .Include(r => r.Order)
                    .ThenInclude(r => r.AppUser)
                    .Where(r => r.Customer.UserName == User.Identity.Name)
                    .ToListAsync();
            if (!User.IsInRole("Host"))
            {
                return View("Index", ods);
            }
            else
            {
                return RedirectToAction("Index", "Properties");
            }
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            ViewBag.AllProperties = GetAllPropertiesAvailable();
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                                            .Include(r => r.Order)     
                                            .Include(r => r.Customer)
                                            .FirstOrDefaultAsync(r => r.ReservationID == id);
            if (User.IsInRole("Customer") && reservation.Customer.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order!  Don't be such a snoop!" });
            }
            if (reservation.Status == Status.Confirmed | reservation.Status == Status.Cancelled)
            {
                ViewBag.ErrorMessage = "This reservation has either already been finalized or cancelled";
                return View("Index");
            }
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
        public async Task<IActionResult> Edit(int id, Reservation paramReservation, int SelectedProperty)
        {
            ViewBag.AllProperties = GetAllPropertiesAvailable();
            if (id != paramReservation.ReservationID)
            {
                return NotFound();
            }
            ViewBag.AllCategories = GetAllPropertiesAvailable();
            if (ModelState.IsValid)
            {
                Reservation reservation = _context.Reservations
                                                .Include(r => r.Order)
                                                .Include(r => r.Property)
                                                .ThenInclude(r => r.Reservations)
                                                .Include(r => r.Customer)
                                                .FirstOrDefault(r => r.ReservationID == paramReservation.ReservationID);
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

                foreach (Reservation currentRsv in reservation.Property.Reservations)
                {
                    string Err = "This reservation time conflicts with a previously held reservation of "
                             + currentRsv.Property.Street + " from "
                             + currentRsv.CheckInDate + " to " + currentRsv.CheckOutDate;
                    if (currentRsv.ReservationID == paramReservation.ReservationID)
                    { } //pass
                    else if(datesConflict(currentRsv.CheckInDate, currentRsv.CheckOutDate, paramReservation.CheckInDate, paramReservation.CheckOutDate))
                    {
                        ViewBag.ErrorMessage = Err;
                        return View(reservation);
                    }
                }
                foreach (Reservation currentRsv in reservation.Order.Reservations)
                {
                    string Err = "This reservation time conflicts with a reservation on this order at "
                          + currentRsv.Property.Street + " from "
                          + currentRsv.CheckInDate + " to " + currentRsv.CheckOutDate;
                    if (currentRsv.ReservationID == paramReservation.ReservationID)
                    { } //pass
                    else if (datesConflict(currentRsv.CheckInDate, currentRsv.CheckOutDate, paramReservation.CheckInDate, paramReservation.CheckOutDate))
                    {
                        ViewBag.ErrorMessage = Err;
                        return View(reservation);
                    }

                }
                
                reservation.CheckInDate = paramReservation.CheckInDate;
                reservation.CheckOutDate = paramReservation.CheckOutDate;
                reservation.CalcExtendedPrice();
                try
                {
                    _context.Update(reservation);
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
            List<Reservation> ods = await _context.Reservations
                    .Include(r => r.Property)
                    .Include(r => r.Order)
                    .ThenInclude(r => r.AppUser)
                    .Where(r => r.Customer.UserName == User.Identity.Name)
                    .ToListAsync();
            return View("Index", ods);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbReservation = await _context.Reservations
                .Include(r => r.Customer)
                .FirstOrDefaultAsync(m => m.ReservationID == id);
            if (User.IsInRole("Customer") && dbReservation.Customer.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order!  Don't be such a snoop!" });
            }

            if (dbReservation.CheckInDate.Subtract(DateTime.Now).TotalMinutes <= 1440)
            {
                return View("Error", new String[] { "You are less than a day away from your reservation, it cannot be cancelled" });
            }
            if (dbReservation == null)
            {
                return NotFound();
            }


            return View(dbReservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Reservation reservation = _context.Reservations.FirstOrDefault(r => r.ReservationID == id);
            reservation.Status = Status.Cancelled;
            _context.Update(reservation);
            await _context.SaveChangesAsync();
            return View("Index");
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

        private bool datesConflict(DateTime min1, DateTime max1, DateTime min2, DateTime max2)
        {
            if (min1.CompareTo(min2) > 0 & min1.CompareTo(max2) < 0)
                return true;
            else if (min2.CompareTo(min1) > 0 & min2.CompareTo(max1) < 0)
                return true;
            else if (min2.CompareTo(min1) == 0)
                return true;
            else
                return false;
        }


        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ReservationID == id);
        }
    }
}
