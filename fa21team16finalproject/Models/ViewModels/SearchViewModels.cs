using System;
using System.ComponentModel.DataAnnotations;

namespace fa21team16finalproject.Models
{
    //Creates class SearchViewModels
    public class SearchViewModels
    {
        //All fields user can input

        [Display(Name = "Search by State: ")]
        public State ?SearchState { get; set; }

        [Display(Name = "Search by City: ")]
        public String SearchCity { get; set; }

        [Display(Name = "Minimum Amount of Guests: ")]
        public Decimal? SearchGuests { get; set; }

        [Display(Name = "Maximum Weekday Price: ")]
        public Decimal? SearchWeekPrice { get; set; }

        [Display(Name = "Maximmum Weekend Price: ")]
        public Decimal? SearchWeekendPrice { get; set; }

        [Display(Name = "Search by category:")]
        public Category SearchCategory { get; set; }

        [Display(Name = "Minimum Bedrooms: ")]
        public Int32? SearchBedrooms { get; set; }

        [Display(Name = "Minimum Bathrooms: ")]
        public Int32? SearchBathrooms { get; set; }

        [DisplayFormat(DataFormatString = "{0:F1}")]
        public decimal? SearchRating { get; set; }
        public Int32 SearchType { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Check In Date:")]
        public DateTime ?SearchStartDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Check Out Date:")]
        public DateTime ?SearchEndDate { get; set; }

        [Display(Name = "Must Allow Pets: ")]
        public bool SearchPets { get; set; }

        [Display(Name = "Must Have Free Parking: ")]
        public bool SearchParking { get; set; }

        //TODO: Add in Guest Ratings Average search, something to do with date search
    }
}
