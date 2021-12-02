using System;
using System.ComponentModel.DataAnnotations;

namespace fa21team16finalproject.Models
{
    //Creates class SearchViewModels
    public class ReportViewModel
    {
        [Key]
        public Int32 Pkey { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Search Start Date:")]
        public DateTime ?SearchStartDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Search End Date:")]
        public DateTime ?SearchEndDate { get; set; }

    }
}
