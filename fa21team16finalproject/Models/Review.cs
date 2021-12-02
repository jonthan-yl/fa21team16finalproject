using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace fa21team16finalproject.Models
{
    public class Review
    {
        //Primary Key
        [Display(Name = "Review ID:")]
        [Required(ErrorMessage = "Review ID is required")]
        public Int32 ReviewID { get; set; }

        [Display(Name = "Rating:")]
        [Required(ErrorMessage = "Must have a rating be an integer  between 1 and 5")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public Int32 Rating { get; set; }

        [Display(Name = "Comments:")]
        public String Comments { get; set; }

        public bool Disputed { get; set; }

        //Navigational Property
        public AppUser Customer { get; set; }

        public Property Property { get; set; }


    }
}
