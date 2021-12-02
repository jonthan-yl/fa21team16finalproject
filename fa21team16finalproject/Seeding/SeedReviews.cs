
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
                Customer = db.Users.FirstOrDefault(u => u.UserName == "father.Ingram@aool.com"),
                Rating = 4,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                Rating = 3,
                Comments = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator.",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "father.Ingram@aool.com"),
                Rating = 4,
                Comments = "",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "tuck33@puppy.com"),
                Rating = 2,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "father.Ingram@aool.com"),
                Rating = 3,
                Comments = "Nebraska was... interesting",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "tfreeley@puppy.com"),
                Rating = 1,
                Comments = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "ra@aoo.com"),
                Rating = 1,
                Comments = "Worst. Stay. Ever. Never using BevoBnB again",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                Rating = 5,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                Rating = 2,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "tfreeley@puppy.com"),
                Rating = 1,
                Comments = "It was SO hard to book this place. Who coded this site anyway? ;)",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "tuck33@puppy.com"),
                Rating = 4,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "ra@aoo.com"),
                Rating = 5,
                Comments = "This place rocked!",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "fd@puppy.com"),
                Rating = 4,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "lamemartin.Martin@aool.com"),
                Rating = 4,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "fd@puppy.com"),
                Rating = 1,
                Comments = "There were 1...5...22 roaches? I lost count.",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "sheff44@puppy.com"),
                Rating = 1,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "fd@puppy.com"),
                Rating = 4,
                Comments = "I LOVED the place! Had a nice view of the mountains",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "tuck33@puppy.com"),
                Rating = 5,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                Rating = 5,
                Comments = "My stay was amazing! Saved my marriage",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "sheff44@puppy.com"),
                Rating = 2,
                Comments = " ",
                Disputed = false,

            });


            AllReviews.Add(new Review
            {
                Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                Rating = 2,
                Comments = "My wife's attitude was the only thing rougher than the sand at the nearby beaches",
                Disputed = false,

            });
        }
    }
}
