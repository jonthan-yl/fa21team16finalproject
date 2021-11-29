using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace fa21team16finalproject.Models
{
    public class Category
    {
        //Primary Key
        [Display(Name = "Category ID:")]
        [Required]
        public Int32 CategoryID { get; set; }

        [Display(Name = "Category Name:")]
        [Required]
        public String Name { get; set; }

        //Navigational Property
        public List<Property> Properties { get; set; }

        public Category()
        {
            if (Properties == null)
            {
                Properties = new List<Property>();
            }
        }
    }
}
