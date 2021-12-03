using fa21team16finalproject.DAL;
using fa21team16finalproject.Models;
using fa21team16finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace fa21team16finalproject.Seeding
{


    public static class SeedCategories
    {
        public static void SeedAllCategories(AppDbContext db)
        {
            List<Category> AllCategories = new List<Category>();



            AllCategories.Add(new Category
            {
                Name = "House",

            });


            AllCategories.Add(new Category
            {
                Name = "Cabin",

            });


            AllCategories.Add(new Category
            {
                Name = "Apartment",

            });


            AllCategories.Add(new Category
            {
                Name = "Condo",

            });


            AllCategories.Add(new Category
            {
                Name = "Hotel",

            });

            //create a counter and flag to help with debugging
            int intCategoryID = 0;
            String strName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artists
                foreach (Category seedCategory in AllCategories)
                {
                    //updates the counters to get info on where the problem is
                    intCategoryID = seedCategory.CategoryID;
                    strName = seedCategory.Name;

                    //try to find the artist in the database
                    Category dbCategory = db.Categories.FirstOrDefault(c => c.Name == seedCategory.Name);

                    //if the artist isn't in the database, dbArtist will be null
                    if (dbCategory == null)
                    {
                        //add the Artist to the database
                        db.Categories.Add(seedCategory);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artist because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbCategory.Name = seedCategory.Name;

                        //you would add other fields here
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex) //something about adding to the database caused a problem
            {
                //create a new instance of the string builder to make building out 
                //our message neater - we don't want a REALLY long line of code for this
                //so we break it up into several lines
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the ");
                msg.Append(strName);
                msg.Append(" category (CategoryID = ");
                msg.Append(intCategoryID);
                msg.Append(")");

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above. The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }

        }
    }

}
