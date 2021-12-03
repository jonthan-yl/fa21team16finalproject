using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using fa21team16finalproject.DAL;

namespace fa21team16finalproject.Models
{
    public enum State { AK, AL, AR, AS, AZ, CA, CO, CT, DC, DE, FL, GA, GU, HI, IA, ID, IL, IN, KS, KY,
        LA, MA, MD, ME, MI, MN, MO, MP, MS, MT, NC, ND, NE, NH, NJ, NM, NV, NY, OH, OK, OR, PA, PR, RI,
        SC, SD, TN, TX, UM, UT, VA, VI, VT, WA, WI, WV, WY }
    public class Property
    {
        //Primary Key
        [Display(Name = "Property ID:")]
        [Required(ErrorMessage = "Property ID is required")]
        public Int32 PropertyID { get; set; }

        [Display(Name = "Property Number:")]
        [Required(ErrorMessage = "Property Number is required")]
        public Int32 PropertyNumber { get; set; }

        [Display(Name = "Property Street:")]
        [Required(ErrorMessage = "Product Street is required")]
        public string Street { get; set; }

        [Display(Name = "Property City:")]
        [Required(ErrorMessage = "Product City is required")]
        public string City { get; set; }

        [Display(Name = "Property State:")]
        [Required(ErrorMessage = "Product State is required")]
        public State State { get; set; }

        [Display(Name = "Property Zip Code:")]
        [Required(ErrorMessage = "Product Zip Code is required")]
        public string ZipCode { get; set; }

        //Only to be charged once per stay
        [Display(Name = "Property Cleaning Fee:")]
        [Required(ErrorMessage = "Property Cleaning Fee is required")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0, 999999)]
        public Decimal CleaningFee { get; set; }

        [Display(Name = "Property Week Night Price:")]
        [Required(ErrorMessage = "Property Week Night Price is required")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0, 999999)]
        public Decimal WeekNightPrice { get; set; }

        [Display(Name = "Property Weekend Night Price:")]
        [Required(ErrorMessage = "Property Weekend Night Price is required")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0, 999999)]
        public Decimal WeekendNightPrice { get; set; }

        [Display(Name = "Number of Bedrooms:")]
        [Required(ErrorMessage = "Number of Bedrooms is required")]
        [Range(0, 999999)]
        public Int32 NumberOfBedrooms { get; set; }

        [Display(Name = "Number of Bathrooms:")]
        [Required(ErrorMessage = "Number of Bathrooms is required")]
        [Range(0, 999999)]
        public Int32 NumberOfBathrooms { get; set; }

        [Display(Name = "Are Pets Allowed?")]
        [Required(ErrorMessage = "You must set whether or not pets are allowed")]
        public bool PetsAllowed { get; set; }

        [Display(Name = "Is there Free Parking?")]
        [Required(ErrorMessage = "You must say whether or not there is free parking")]
        public bool FreeParking { get; set; }

        [Display(Name = "Guest Limit:")]
        [Required(ErrorMessage = "Guest Limit is required")]
        [Range(0, 999999)]
        public Int32 GuestLimit { get; set; }

        [Display(Name = "Days for discount to activate:")]
        [Required(ErrorMessage = "Enter 0 if no discount")]
        public Int32 DiscountDays { get; set; }

        [Display(Name = "Discount Percentage:")]
        [Range(0, 1)]
        public decimal? PercentDiscount { get; set; }

        [DisplayFormat(DataFormatString = "{0:F1}")]
        public decimal Rating { get; set; }
        public bool isDisabled { get; set; }

        public bool isPending { get; set; }

        //Navigational Properties
        //Upon instantiation of property
        public Category Category { get; set; }

        public AppUser Host { get; set; }
        //Upon creation of review, and reservation respectfully

        public List<Review> Reviews { get; set; }

        public List<Reservation> Reservations { get; set; }

        public void calcRating()
        {
            if (Reviews == null)
            {
                return;
            }
            decimal reviewCount = 0;
            foreach (Review review in Reviews)
            {
                reviewCount += review.Rating;
            }
            if (Reviews.Count != 0)
            {
                Rating = reviewCount / Reviews.Count;
            }
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

        public bool propertyAvailability(DateTime startDate, DateTime endDate)
        {
            foreach (Reservation currentRsv in Reservations)
            {
                if (datesConflict(startDate, endDate, currentRsv.CheckInDate, currentRsv.CheckOutDate))
                {
                    return false;
                }
            }
            return true;
        }
        public Property()
        {
            calcRating();
            if(isDisabled != true)
            {
                isDisabled = false;
            }
            if (isPending != false)
            {
                isPending = true;
            }
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }
            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

        }
    }
}
