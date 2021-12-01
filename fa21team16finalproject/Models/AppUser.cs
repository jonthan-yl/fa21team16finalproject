using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using fa21team16finalproject.Utilities;

namespace fa21team16finalproject.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Display(Name = "Birthday:")]
        [DataType(DataType.Date)]
        [MinAge(18)]
        [Required(ErrorMessage = "Birthday is required")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "IsActive is required")]
        public bool IsActive { get; set; }

        [Display(Name = "Address:")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        public Int32 ZipCode { get; set; }

        //Navigational Properties
        public List<Order> Orders { get; set; }

        public List<Review> Reviews { get; set;}

        public List<Property> Properties { get; set; }

        public AppUser()
        {
            if (Orders == null)
            {
                Orders = new List<Order>();
            }
            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }
            if (Properties == null)
            {
                Properties = new List<Property>();
            }
        }
    }
}
