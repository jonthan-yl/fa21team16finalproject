using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace fa21team16finalproject.Models
{
    public class Reservation
    {
        //Primary Key
        [Required(ErrorMessage = "PK is required")]
        public Int32 ReservationID { get; set; }

        [Display(Name = "Check In Date:")]
        [Required(ErrorMessage = "Check In Date is required")]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Display(Name = "Check Out Date:")]
        [Required(ErrorMessage = "Check Out Date is required")]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        public int TotalDays 
        {
            get { return CheckOutDate.Subtract(CheckInDate).Days; }
            set { }
        }

        //Product price at time of ordering
        [Display(Name = "Property Week Night Price:")]
        [Required(ErrorMessage = "Property Week Night Price is required")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal WeekNightPrice { get; set; }


        [Display(Name = "Property Weekend Night Price:")]
        [Required(ErrorMessage = "Property Weekend Night Price is required")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal WeekendNightPrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal CleaningFee { get; set; }
        public Int32 DiscountDays { get; set; }
        public decimal? PercentDiscount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal StayTotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ExtendedPrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Discount { get; set; }


        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Total { get; set; }

        public const Decimal TAX_RATE = 0.1m;
        //Navigational Properties
        public Order? Order { get; set; }

        public Property Property { get; set; }

        public AppUser Customer { get; set; }

        //Calculating ExtendedPrice
        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date < thru.Date; day = day.AddDays(1))
                yield return day;
        }
        
        public void CalcExtendedPrice()
        {
            foreach (DateTime day in Reservation.EachDay(CheckInDate, CheckOutDate))
            {
                if (day.DayOfWeek == DayOfWeek.Friday | day.DayOfWeek == DayOfWeek.Saturday)
                {
                    ExtendedPrice = ExtendedPrice + WeekendNightPrice;
                }
                else
                {
                    ExtendedPrice = ExtendedPrice + WeekNightPrice;
                }
            }
            
            StayTotal = ExtendedPrice;
            ExtendedPrice = ExtendedPrice + CleaningFee;
            if (TotalDays >= DiscountDays & !(PercentDiscount == null | DiscountDays == 0))
            {
                Discount = (decimal)(ExtendedPrice * PercentDiscount);
                ExtendedPrice = ExtendedPrice - Discount;
            }
            decimal Tax = TAX_RATE * ExtendedPrice;
            Total = Tax + ExtendedPrice;
        }
        public Reservation ()
        {
            CalcExtendedPrice();
        }
    }
}
