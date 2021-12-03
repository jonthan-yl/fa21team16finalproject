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


    public static class SeedReviews
    {
        public static void SeedAllReviews(AppDbContext db)
        {
            List<Review> AllReviews = new List<Review>();



            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Port Stephanieville"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "father.Ingram@aool.com"),
                Rating = 4,
                Comments = " ",
                Disputed = false,

            }); ; ;


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Port Trevor"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                Rating = 3,
                Comments = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator.",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Port Trevor"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "father.Ingram@aool.com"),
                Rating = 4,
                Comments = "",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Port Stephanieville"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "tuck33@puppy.com"),
                Rating = 2,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Florestown"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "father.Ingram@aool.com"),
                Rating = 3,
                Comments = "Nebraska was... interesting",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Florestown"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "tfreeley@puppy.com"),
                Rating = 1,
                Comments = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Florestown"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "ra@aoo.com"),
                Rating = 1,
                Comments = "Worst. Stay. Ever. Never using BevoBnB again",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Lake Michael"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                Rating = 5,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Lake Patrickstad"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                Rating = 2,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Lake Michael"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "tfreeley@puppy.com"),
                Rating = 1,
                Comments = "It was SO hard to book this place. Who coded this site anyway? ;)",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Chelsealand"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "tuck33@puppy.com"),
                Rating = 4,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Lake Michael"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "ra@aoo.com"),
                Rating = 5,
                Comments = "This place rocked!",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Lake Michael"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "fd@puppy.com"),
                Rating = 4,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Lake Patrickstad"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "lamemartin.Martin@aool.com"),
                Rating = 4,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Florestown"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "fd@puppy.com"),
                Rating = 1,
                Comments = "There were 1...5...22 roaches? I lost count.",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Port Trevor"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "sheff44@puppy.com"),
                Rating = 1,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "West Haleyburgh"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "fd@puppy.com"),
                Rating = 4,
                Comments = "I LOVED the place! Had a nice view of the mountains",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "West Haleyburgh"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "tuck33@puppy.com"),
                Rating = 5,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Port Stephanieville"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                Rating = 5,
                Comments = "My stay was amazing! Saved my marriage",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "Lake Patrickstad"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "sheff44@puppy.com"),
                Rating = 2,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Property = db.Properties.FirstOrDefault(p => p.City == "East Michaelfort"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                Rating = 2,
                Comments = "My wife's attitude was the only thing rougher than the sand at the nearby beaches",
                Disputed = false,

            });

            int intReviewID = 0;
            String strReviewName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artists
                foreach (Review review in AllReviews)
                {
                    //updates the counters to get info on where the problem is
                    intReviewID = review.ReviewID;


                    //try to find the artist in the database
                    Review dbReview = db.Reviews.FirstOrDefault(c => c.ReviewID == review.ReviewID);

                    //if the artist isn't in the database, dbArtist will be null
                    if (dbReview == null)
                    {
                        //add the Artist to the database
                        db.Reviews.Add(review);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artist because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbReview.ReviewID = review.ReviewID;

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
                msg.Append(strReviewName);
                msg.Append(" Review (ReviewID = ");
                msg.Append(intReviewID);
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
