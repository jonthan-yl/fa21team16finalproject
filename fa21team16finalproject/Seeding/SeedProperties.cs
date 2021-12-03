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
    public static class SeedProperties
    {
        public static void SeedAllProperties(AppDbContext db)
        {
            List<Property> AllProperties = new List<Property>();

            Category House = db.Categories.FirstOrDefault(c => c.Name == "House");
            Category Condo = db.Categories.FirstOrDefault(c => c.Name == "Condo");
            Category Hotel = db.Categories.FirstOrDefault(c => c.Name == "Hotel");
            Category Apartment = db.Categories.FirstOrDefault(c => c.Name == "Apartment");
            Category Cabin = db.Categories.FirstOrDefault(c => c.Name == "Cabin");

            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an exAEFEAFEAFEAFample
                State = State.PA,
                Street = "8714 Mann Plaza",
                City = "Lisaside",
                ZipCode = "72227",
                WeekNightPrice = Convert.ToDecimal(152.68),
                WeekendNightPrice = Convert.ToDecimal(171.57),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(8.88),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                
                State = State.FL,
                Street = "96593 White View Apt. 094",
                City = "Jonesberg",
                ZipCode = "5565",
                WeekNightPrice = Convert.ToDecimal(120.81),
                WeekendNightPrice = Convert.ToDecimal(148.15),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(8.02),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(8),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MD,
                Street = "848 Melissa Springs Suite 947",
                City = "Kellerstad",
                ZipCode = "80819",
                WeekNightPrice = Convert.ToDecimal(127.96),
                WeekendNightPrice = Convert.ToDecimal(132.99),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(13.37),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(8),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.ND,
                Street = "30413 Norton Isle Suite 012",
                City = "North Lisa",
                ZipCode = "79428",
                WeekNightPrice = Convert.ToDecimal(80.2),
                WeekendNightPrice = Convert.ToDecimal(185.35),
                Category = Hotel,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(5.57),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.DE,
                Street = "39916 Mitchell Crescent",
                City = "New Andrewburgh",
                ZipCode = "63315",
                WeekNightPrice = Convert.ToDecimal(170.25),
                WeekendNightPrice = Convert.ToDecimal(100.37),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(18.64),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(12),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NE,
                Street = "086 Mary Cliff",
                City = "North Deborah",
                ZipCode = "24135",
                WeekNightPrice = Convert.ToDecimal(220.24),
                WeekendNightPrice = Convert.ToDecimal(162.6),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(10.83),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(9),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.PA,
                Street = "91634 Strong Mountains Apt. 302",
                City = "West Alyssa",
                ZipCode = "58475",
                WeekNightPrice = Convert.ToDecimal(213.37),
                WeekendNightPrice = Convert.ToDecimal(204.87),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(25.04),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WA,
                Street = "6984 Price Shoals",
                City = "Erictown",
                ZipCode = "10865",
                WeekNightPrice = Convert.ToDecimal(159.69),
                WeekendNightPrice = Convert.ToDecimal(140.89),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(27.13),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(8),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.ME,
                Street = "423 Bell Heights",
                City = "Brittanyberg",
                ZipCode = "51359",
                WeekNightPrice = Convert.ToDecimal(200.73),
                WeekendNightPrice = Convert.ToDecimal(295.39),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(14.91),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WI,
                Street = "93523 Dana Lane",
                City = "Johnsonshire",
                ZipCode = "87296",
                WeekNightPrice = Convert.ToDecimal(170.39),
                WeekendNightPrice = Convert.ToDecimal(110.8),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(8.67),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NH,
                Street = "1427 Odonnell Rapids",
                City = "North Troyport",
                ZipCode = "7035",
                WeekNightPrice = Convert.ToDecimal(217.15),
                WeekendNightPrice = Convert.ToDecimal(126.29),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(26.48),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.ME,
                Street = "81206 Stewart Forest Apt. 089",
                City = "East Davidborough",
                ZipCode = "37198",
                WeekNightPrice = Convert.ToDecimal(205.21),
                WeekendNightPrice = Convert.ToDecimal(293.26),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(28.74),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(8),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SD,
                Street = "76104 Marsh Crescent",
                City = "Dennishaven",
                ZipCode = "85034",
                WeekNightPrice = Convert.ToDecimal(123.13),
                WeekendNightPrice = Convert.ToDecimal(126.99),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(18.73),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SD,
                Street = "0003 Grant Lakes",
                City = "Port Karafort",
                ZipCode = "60619",
                WeekNightPrice = Convert.ToDecimal(89.19),
                WeekendNightPrice = Convert.ToDecimal(188.81),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(11.98),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.KY,
                Street = "236 Smith Drive Suite 555",
                City = "West Kimberlyton",
                ZipCode = "21978",
                WeekNightPrice = Convert.ToDecimal(198.3),
                WeekendNightPrice = Convert.ToDecimal(132.96),
                Category = Condo,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(13.96),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MT,
                Street = "6824 Timothy Garden Apt. 428",
                City = "West Richardmouth",
                ZipCode = "14742",
                WeekNightPrice = Convert.ToDecimal(181.5),
                WeekendNightPrice = Convert.ToDecimal(297.31),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(10.09),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SC,
                Street = "5517 Holly Meadow Apt. 452",
                City = "Lake Anne",
                ZipCode = "11894",
                WeekNightPrice = Convert.ToDecimal(134.09),
                WeekendNightPrice = Convert.ToDecimal(139.22),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(9.75),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.TX,
                Street = "30601 Hawkins Highway",
                City = "Morashire",
                ZipCode = "28976",
                WeekNightPrice = Convert.ToDecimal(187.65),
                WeekendNightPrice = Convert.ToDecimal(160.61),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(7.5),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.AZ,
                Street = "49263 Wilson View Apt. 873",
                City = "South Raymondborough",
                ZipCode = "28798",
                WeekNightPrice = Convert.ToDecimal(206.95),
                WeekendNightPrice = Convert.ToDecimal(133.25),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(14.04),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(5),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NE,
                Street = "76582 Vanessa Oval",
                City = "New Richard",
                ZipCode = "68819",
                WeekNightPrice = Convert.ToDecimal(99.54),
                WeekendNightPrice = Convert.ToDecimal(242.89),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(6.61),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(12),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.FL,
                Street = "7389 Alec Squares Suite 508",
                City = "Port Jonathan",
                ZipCode = "50177",
                WeekNightPrice = Convert.ToDecimal(112.62),
                WeekendNightPrice = Convert.ToDecimal(165.32),
                Category = Condo,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(24.26),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(12),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NC,
                Street = "18013 Billy Bridge Suite 522",
                City = "Schmitthaven",
                ZipCode = "66355",
                WeekNightPrice = Convert.ToDecimal(199.21),
                WeekendNightPrice = Convert.ToDecimal(119.02),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(11.63),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NJ,
                Street = "891 Bullock Ford",
                City = "Amandachester",
                ZipCode = "51431",
                WeekNightPrice = Convert.ToDecimal(179.05),
                WeekendNightPrice = Convert.ToDecimal(244.93),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(21.78),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MT,
                Street = "02489 Cook Park",
                City = "Sherriport",
                ZipCode = "50853",
                WeekNightPrice = Convert.ToDecimal(207.24),
                WeekendNightPrice = Convert.ToDecimal(227.35),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(5.5),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.UT,
                Street = "23450 Timothy Divide",
                City = "Wuland",
                ZipCode = "20341",
                WeekNightPrice = Convert.ToDecimal(116.01),
                WeekendNightPrice = Convert.ToDecimal(278.36),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(24.73),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.OH,
                Street = "0976 Williams Mountains Apt. 009",
                City = "Lake Mario",
                ZipCode = "85565",
                WeekNightPrice = Convert.ToDecimal(225.14),
                WeekendNightPrice = Convert.ToDecimal(293.42),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(10.42),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WY,
                Street = "1097 Santos Springs Suite 264",
                City = "New Michelleborough",
                ZipCode = "51884",
                WeekNightPrice = Convert.ToDecimal(70.24),
                WeekendNightPrice = Convert.ToDecimal(126.45),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(18.69),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SC,
                Street = "5100 Scott Burg",
                City = "East Clayton",
                ZipCode = "66353",
                WeekNightPrice = Convert.ToDecimal(186.38),
                WeekendNightPrice = Convert.ToDecimal(224.07),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(28.24),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NV,
                Street = "412 Snow Manors Apt. 161",
                City = "South Kimtown",
                ZipCode = "57004",
                WeekNightPrice = Convert.ToDecimal(112.47),
                WeekendNightPrice = Convert.ToDecimal(120.93),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(23.28),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IN,
                Street = "5415 David Square",
                City = "West Michaeltown",
                ZipCode = "48447",
                WeekNightPrice = Convert.ToDecimal(214.81),
                WeekendNightPrice = Convert.ToDecimal(100.02),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(17.78),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(9),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.DE,
                Street = "03104 Norris Rapids",
                City = "Port Donald",
                ZipCode = "62982",
                WeekNightPrice = Convert.ToDecimal(159.87),
                WeekendNightPrice = Convert.ToDecimal(161.6),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(10.34),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.FL,
                Street = "03557 Phillips Wells Suite 291",
                City = "New Beverlyburgh",
                ZipCode = "16915",
                WeekNightPrice = Convert.ToDecimal(70.55),
                WeekendNightPrice = Convert.ToDecimal(203.6),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(5.09),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MT,
                Street = "332 Watson Shore Apt. 290",
                City = "Millerland",
                ZipCode = "39742",
                WeekNightPrice = Convert.ToDecimal(176.37),
                WeekendNightPrice = Convert.ToDecimal(299.34),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(17.38),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MS,
                Street = "645 John Roads",
                City = "Danahaven",
                ZipCode = "54060",
                WeekNightPrice = Convert.ToDecimal(172.83),
                WeekendNightPrice = Convert.ToDecimal(229.98),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(23.55),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.HI,
                Street = "3547 Stephanie Underpass Apt. 418",
                City = "Port Jacqueline",
                ZipCode = "55774",
                WeekNightPrice = Convert.ToDecimal(177.08),
                WeekendNightPrice = Convert.ToDecimal(143.71),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(19.21),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(5),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.UT,
                Street = "5825 Welch Corners",
                City = "Fischerport",
                ZipCode = "59363",
                WeekNightPrice = Convert.ToDecimal(76.66),
                WeekendNightPrice = Convert.ToDecimal(113.86),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(27.87),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IN,
                Street = "41489 Roger Terrace",
                City = "Davisfort",
                ZipCode = "71770",
                WeekNightPrice = Convert.ToDecimal(177.37),
                WeekendNightPrice = Convert.ToDecimal(299.09),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(23.78),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CO,
                Street = "014 Aaron Locks Suite 714",
                City = "Justinborough",
                ZipCode = "5147",
                WeekNightPrice = Convert.ToDecimal(104.05),
                WeekendNightPrice = Convert.ToDecimal(158.42),
                Category = Condo,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(5.36),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(5),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SC,
                Street = "8518 Pamela Track Apt. 164",
                City = "Aprilshire",
                ZipCode = "28062",
                WeekNightPrice = Convert.ToDecimal(199.37),
                WeekendNightPrice = Convert.ToDecimal(210.59),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(8.83),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.OH,
                Street = "864 Ramos Port Apt. 211",
                City = "Moralesmouth",
                ZipCode = "88090",
                WeekNightPrice = Convert.ToDecimal(94.48),
                WeekendNightPrice = Convert.ToDecimal(153.69),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(16.85),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.RI,
                Street = "637 Neal Island Suite 074",
                City = "Lake Tyler",
                ZipCode = "28775",
                WeekNightPrice = Convert.ToDecimal(88.82),
                WeekendNightPrice = Convert.ToDecimal(196.14),
                Category = Condo,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(6.97),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WV,
                Street = "0811 Smith Canyon Apt. 904",
                City = "Jessicabury",
                ZipCode = "75585",
                WeekNightPrice = Convert.ToDecimal(119.58),
                WeekendNightPrice = Convert.ToDecimal(123.22),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(18.45),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MD,
                Street = "7562 Fisher Spur",
                City = "Hernandezberg",
                ZipCode = "17438",
                WeekNightPrice = Convert.ToDecimal(218.87),
                WeekendNightPrice = Convert.ToDecimal(283.77),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(19.07),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.VT,
                Street = "5667 Blair Underpass",
                City = "South Shelby",
                ZipCode = "7027",
                WeekNightPrice = Convert.ToDecimal(76.19),
                WeekendNightPrice = Convert.ToDecimal(239.76),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(11.37),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MI,
                Street = "6708 Carpenter Overpass Suite 735",
                City = "Bobbyton",
                ZipCode = "1008",
                WeekNightPrice = Convert.ToDecimal(161.17),
                WeekendNightPrice = Convert.ToDecimal(229.04),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(25.01),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.ND,
                Street = "16396 Shawn Junction",
                City = "New Nicolemouth",
                ZipCode = "60236",
                WeekNightPrice = Convert.ToDecimal(106.06),
                WeekendNightPrice = Convert.ToDecimal(220.69),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(11.82),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CA,
                Street = "4486 Olson Well",
                City = "North Kevin",
                ZipCode = "1707",
                WeekNightPrice = Convert.ToDecimal(151.44),
                WeekendNightPrice = Convert.ToDecimal(138.96),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(6.72),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.HI,
                Street = "67771 Christopher Courts Apt. 637",
                City = "Port Ronaldfurt",
                ZipCode = "33233",
                WeekNightPrice = Convert.ToDecimal(102.43),
                WeekendNightPrice = Convert.ToDecimal(134.28),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(19.81),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NY,
                Street = "5561 Bishop Turnpike",
                City = "Lake Kenneth",
                ZipCode = "79756",
                WeekNightPrice = Convert.ToDecimal(94.31),
                WeekendNightPrice = Convert.ToDecimal(259.87),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(22.33),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SD,
                Street = "3019 Gerald Mall Apt. 340",
                City = "Trevinoville",
                ZipCode = "36216",
                WeekNightPrice = Convert.ToDecimal(151.69),
                WeekendNightPrice = Convert.ToDecimal(263.32),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(13.27),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NY,
                Street = "84331 Leonard Fort Suite 749",
                City = "East Lisa",
                ZipCode = "43477",
                WeekNightPrice = Convert.ToDecimal(204.04),
                WeekendNightPrice = Convert.ToDecimal(204.28),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(11.07),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.VA,
                Street = "62281 Kathy Tunnel",
                City = "Hudsonborough",
                ZipCode = "17819",
                WeekNightPrice = Convert.ToDecimal(165.51),
                WeekendNightPrice = Convert.ToDecimal(224.19),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(24.26),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NM,
                Street = "9927 Christina Burg Suite 774",
                City = "East Angelaburgh",
                ZipCode = "97149",
                WeekNightPrice = Convert.ToDecimal(106.87),
                WeekendNightPrice = Convert.ToDecimal(121.74),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(5.62),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(9),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IA,
                Street = "142 Warner View Suite 460",
                City = "North Leslie",
                ZipCode = "45480",
                WeekNightPrice = Convert.ToDecimal(212.32),
                WeekendNightPrice = Convert.ToDecimal(148.76),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(20.2),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.AR,
                Street = "5240 Berry Centers",
                City = "West Andrew",
                ZipCode = "3720",
                WeekNightPrice = Convert.ToDecimal(164.02),
                WeekendNightPrice = Convert.ToDecimal(111.01),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(26.21),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(12),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.HI,
                Street = "51056 Patricia Forge",
                City = "Grahamstad",
                ZipCode = "85576",
                WeekNightPrice = Convert.ToDecimal(117.45),
                WeekendNightPrice = Convert.ToDecimal(167.53),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(24.75),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(9),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.VA,
                Street = "0648 Malone Port Apt. 662",
                City = "New Devonhaven",
                ZipCode = "92199",
                WeekNightPrice = Convert.ToDecimal(209.47),
                WeekendNightPrice = Convert.ToDecimal(176.53),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(5.83),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(12),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SC,
                Street = "23028 Jennifer Meadow Apt. 972",
                City = "West Matthewfurt",
                ZipCode = "5261",
                WeekNightPrice = Convert.ToDecimal(153.04),
                WeekendNightPrice = Convert.ToDecimal(199.1),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(18.62),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.LA,
                Street = "2738 Martin Terrace Suite 547",
                City = "Smithhaven",
                ZipCode = "72649",
                WeekNightPrice = Convert.ToDecimal(196.56),
                WeekendNightPrice = Convert.ToDecimal(199.22),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(20.71),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.KY,
                Street = "984 Stephen Stravenue",
                City = "South Michaelton",
                ZipCode = "97488",
                WeekNightPrice = Convert.ToDecimal(117.03),
                WeekendNightPrice = Convert.ToDecimal(178.29),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(6.47),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.LA,
                Street = "98522 Mathis Viaduct Apt. 909",
                City = "West Michael",
                ZipCode = "42837",
                WeekNightPrice = Convert.ToDecimal(133.35),
                WeekendNightPrice = Convert.ToDecimal(252.79),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(9.15),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.OH,
                Street = "620 Ashley Mills Apt. 507",
                City = "Julieborough",
                ZipCode = "56059",
                WeekNightPrice = Convert.ToDecimal(171.15),
                WeekendNightPrice = Convert.ToDecimal(296.05),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(18.26),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.LA,
                Street = "212 Shelly Roads",
                City = "Fischerview",
                ZipCode = "2288",
                WeekNightPrice = Convert.ToDecimal(132.81),
                WeekendNightPrice = Convert.ToDecimal(163.88),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(7.46),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.OK,
                Street = "8885 Lee Tunnel Suite 208",
                City = "Port Donna",
                ZipCode = "50851",
                WeekNightPrice = Convert.ToDecimal(228.84),
                WeekendNightPrice = Convert.ToDecimal(140.73),
                Category = Hotel,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(17.13),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NM,
                Street = "693 Michael Estate",
                City = "Lake Michael",
                ZipCode = "3009",
                WeekNightPrice = Convert.ToDecimal(155.03),
                WeekendNightPrice = Convert.ToDecimal(139.83),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(21.05),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NY,
                Street = "342 Miller Mission",
                City = "Lake Jennifer",
                ZipCode = "92905",
                WeekNightPrice = Convert.ToDecimal(128.41),
                WeekendNightPrice = Convert.ToDecimal(249.24),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(6.63),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.AK,
                Street = "71664 Kim Throughway",
                City = "Chelsealand",
                ZipCode = "65056",
                WeekNightPrice = Convert.ToDecimal(163.68),
                WeekendNightPrice = Convert.ToDecimal(286.53),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(25.57),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.AZ,
                Street = "66660 Gomez Port Apt. 945",
                City = "South Thomashaven",
                ZipCode = "11181",
                WeekNightPrice = Convert.ToDecimal(93.86),
                WeekendNightPrice = Convert.ToDecimal(137.17),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(28.18),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.FL,
                Street = "0131 Williams Ville Apt. 562",
                City = "Richardberg",
                ZipCode = "53480",
                WeekNightPrice = Convert.ToDecimal(86.25),
                WeekendNightPrice = Convert.ToDecimal(120.61),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(11.39),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.OR,
                Street = "22708 Madison Spurs",
                City = "Herringstad",
                ZipCode = "11353",
                WeekNightPrice = Convert.ToDecimal(182.46),
                WeekendNightPrice = Convert.ToDecimal(241.25),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(18.29),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.FL,
                Street = "3454 Holmes Motorway",
                City = "Port Rachel",
                ZipCode = "5560",
                WeekNightPrice = Convert.ToDecimal(89.88),
                WeekendNightPrice = Convert.ToDecimal(123.04),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(19.14),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.GA,
                Street = "805 James Turnpike",
                City = "Carrmouth",
                ZipCode = "93500",
                WeekNightPrice = Convert.ToDecimal(81.55),
                WeekendNightPrice = Convert.ToDecimal(219.86),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(13.38),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(12),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NV,
                Street = "8081 Smith Trail",
                City = "North Ronaldstad",
                ZipCode = "44515",
                WeekNightPrice = Convert.ToDecimal(130.47),
                WeekendNightPrice = Convert.ToDecimal(196.09),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(14.53),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MS,
                Street = "125 Ian Crossroad Apt. 593",
                City = "South Deannaport",
                ZipCode = "7347",
                WeekNightPrice = Convert.ToDecimal(148.1),
                WeekendNightPrice = Convert.ToDecimal(136.82),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(15.57),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NH,
                Street = "1607 Munoz River",
                City = "Emilyshire",
                ZipCode = "54532",
                WeekNightPrice = Convert.ToDecimal(147.55),
                WeekendNightPrice = Convert.ToDecimal(209.77),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(27.65),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.UT,
                Street = "3615 David Keys Apt. 269",
                City = "West Stephenside",
                ZipCode = "65516",
                WeekNightPrice = Convert.ToDecimal(86.8),
                WeekendNightPrice = Convert.ToDecimal(126.47),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(17.6),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.AZ,
                Street = "640 Mary Common",
                City = "Michaelville",
                ZipCode = "20721",
                WeekNightPrice = Convert.ToDecimal(121.75),
                WeekendNightPrice = Convert.ToDecimal(173.01),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(12.53),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.LA,
                Street = "395 Timothy Road",
                City = "Williamsbury",
                ZipCode = "43567",
                WeekNightPrice = Convert.ToDecimal(160.23),
                WeekendNightPrice = Convert.ToDecimal(198.1),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(10.82),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(5),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.OR,
                Street = "3267 Walter Dam",
                City = "Cunninghamtown",
                ZipCode = "1239",
                WeekNightPrice = Convert.ToDecimal(110.64),
                WeekendNightPrice = Convert.ToDecimal(127.7),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(26.67),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MS,
                Street = "00580 Brandon Creek",
                City = "Port Eric",
                ZipCode = "3966",
                WeekNightPrice = Convert.ToDecimal(227.6),
                WeekendNightPrice = Convert.ToDecimal(236.71),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(20.22),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MS,
                Street = "325 Amanda Cliffs Apt. 695",
                City = "South Paulabury",
                ZipCode = "29996",
                WeekNightPrice = Convert.ToDecimal(115.37),
                WeekendNightPrice = Convert.ToDecimal(135.59),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(29.8),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CT,
                Street = "40956 Amanda Walk Apt. 260",
                City = "Simonfurt",
                ZipCode = "93980",
                WeekNightPrice = Convert.ToDecimal(93.35),
                WeekendNightPrice = Convert.ToDecimal(271.49),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(8.54),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(5),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.KS,
                Street = "25762 Gill Creek Suite 525",
                City = "Mccoyton",
                ZipCode = "23687",
                WeekNightPrice = Convert.ToDecimal(171.37),
                WeekendNightPrice = Convert.ToDecimal(247.15),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(17.22),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(5),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.GA,
                Street = "6048 Johnson Loop Suite 635",
                City = "East Daniel",
                ZipCode = "4593",
                WeekNightPrice = Convert.ToDecimal(95.59),
                WeekendNightPrice = Convert.ToDecimal(299.6),
                Category = Condo,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(24.3),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(8),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.RI,
                Street = "1168 Gary Fords Apt. 308",
                City = "Port Trevor",
                ZipCode = "96954",
                WeekNightPrice = Convert.ToDecimal(194.84),
                WeekendNightPrice = Convert.ToDecimal(278.17),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(5.88),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MS,
                Street = "164 Matthew Parkway Suite 826",
                City = "Jimmyfurt",
                ZipCode = "62271",
                WeekNightPrice = Convert.ToDecimal(112.03),
                WeekendNightPrice = Convert.ToDecimal(100.08),
                Category = Condo,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(28.82),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(8),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CO,
                Street = "1220 Heidi Rue Apt. 998",
                City = "West Haleyburgh",
                ZipCode = "5222",
                WeekNightPrice = Convert.ToDecimal(127.97),
                WeekendNightPrice = Convert.ToDecimal(182.77),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(13.02),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SD,
                Street = "751 Wood Square Suite 732",
                City = "Port Melissaburgh",
                ZipCode = "22365",
                WeekNightPrice = Convert.ToDecimal(120.07),
                WeekendNightPrice = Convert.ToDecimal(186.01),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(26.71),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.OR,
                Street = "376 Smith Dale Suite 279",
                City = "South Sarahland",
                ZipCode = "53609",
                WeekNightPrice = Convert.ToDecimal(137.96),
                WeekendNightPrice = Convert.ToDecimal(122.31),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(26.29),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CA,
                Street = "79148 Pierce Lock Suite 423",
                City = "Erikberg",
                ZipCode = "9478",
                WeekNightPrice = Convert.ToDecimal(226.57),
                WeekendNightPrice = Convert.ToDecimal(234.61),
                Category = Hotel,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(16.41),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.ID,
                Street = "147 Lisa Hill Apt. 512",
                City = "Port Elizabethshire",
                ZipCode = "1425",
                WeekNightPrice = Convert.ToDecimal(95.73),
                WeekendNightPrice = Convert.ToDecimal(145.15),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(9.93),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.KY,
                Street = "971 Hansen Well Suite 103",
                City = "South Mary",
                ZipCode = "29941",
                WeekNightPrice = Convert.ToDecimal(161.68),
                WeekendNightPrice = Convert.ToDecimal(145.72),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(24.36),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WY,
                Street = "511 Berry Fork Suite 623",
                City = "Sharonfort",
                ZipCode = "47577",
                WeekNightPrice = Convert.ToDecimal(183.81),
                WeekendNightPrice = Convert.ToDecimal(260.18),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(7.46),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WI,
                Street = "65873 Chen Knolls",
                City = "Ramirezfurt",
                ZipCode = "94134",
                WeekNightPrice = Convert.ToDecimal(215.38),
                WeekendNightPrice = Convert.ToDecimal(117.17),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(24.31),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IN,
                Street = "8799 Emma Parkway Suite 735",
                City = "North Thomasfurt",
                ZipCode = "57039",
                WeekNightPrice = Convert.ToDecimal(145.51),
                WeekendNightPrice = Convert.ToDecimal(242.21),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(11.89),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.ND,
                Street = "30068 David View Apt. 173",
                City = "New Peggychester",
                ZipCode = "23718",
                WeekNightPrice = Convert.ToDecimal(142.76),
                WeekendNightPrice = Convert.ToDecimal(161.21),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(20.92),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MD,
                Street = "298 Johnathan Cove Apt. 402",
                City = "South Jamie",
                ZipCode = "26932",
                WeekNightPrice = Convert.ToDecimal(170.07),
                WeekendNightPrice = Convert.ToDecimal(176.37),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(8.54),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CO,
                Street = "171 Harrison Motorway",
                City = "Davidview",
                ZipCode = "74554",
                WeekNightPrice = Convert.ToDecimal(145.08),
                WeekendNightPrice = Convert.ToDecimal(234.81),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(26.14),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NE,
                Street = "3576 Sergio Avenue",
                City = "Benjaminmouth",
                ZipCode = "32097",
                WeekNightPrice = Convert.ToDecimal(111.73),
                WeekendNightPrice = Convert.ToDecimal(260.62),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(15.89),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.RI,
                Street = "37457 Tanya Pike Apt. 348",
                City = "North Ericton",
                ZipCode = "21519",
                WeekNightPrice = Convert.ToDecimal(70.63),
                WeekendNightPrice = Convert.ToDecimal(214.62),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(5.29),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.PA,
                Street = "3673 Peter Turnpike Suite 835",
                City = "New Sandra",
                ZipCode = "76875",
                WeekNightPrice = Convert.ToDecimal(229.03),
                WeekendNightPrice = Convert.ToDecimal(172.79),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(14.05),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.TX,
                Street = "939 Johnson Oval Suite 830",
                City = "North Dennismouth",
                ZipCode = "80451",
                WeekNightPrice = Convert.ToDecimal(169.34),
                WeekendNightPrice = Convert.ToDecimal(133.53),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(18.06),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NV,
                Street = "645 Jennings Estates",
                City = "Angelastad",
                ZipCode = "51726",
                WeekNightPrice = Convert.ToDecimal(155.52),
                WeekendNightPrice = Convert.ToDecimal(109.44),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(8.28),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MT,
                Street = "1231 Stephanie Lock Suite 835",
                City = "North Richardland",
                ZipCode = "77240",
                WeekNightPrice = Convert.ToDecimal(180.2),
                WeekendNightPrice = Convert.ToDecimal(182.33),
                Category = Hotel,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(17.78),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(5),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CO,
                Street = "302 Parker Plains Apt. 197",
                City = "East Robertstad",
                ZipCode = "98152",
                WeekNightPrice = Convert.ToDecimal(212.86),
                WeekendNightPrice = Convert.ToDecimal(212.7),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(6.82),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MS,
                Street = "098 Hernandez Green",
                City = "New Sergiobury",
                ZipCode = "98277",
                WeekNightPrice = Convert.ToDecimal(188.71),
                WeekendNightPrice = Convert.ToDecimal(262.3),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(21.88),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(8),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NE,
                Street = "94102 Sims Port Suite 187",
                City = "Florestown",
                ZipCode = "80082",
                WeekNightPrice = Convert.ToDecimal(83.34),
                WeekendNightPrice = Convert.ToDecimal(128.05),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(11.29),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(8),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.ND,
                Street = "01630 Baker Crescent",
                City = "Kellyborough",
                ZipCode = "71531",
                WeekNightPrice = Convert.ToDecimal(204.02),
                WeekendNightPrice = Convert.ToDecimal(125.27),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(21.15),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.OK,
                Street = "70452 Forbes Courts",
                City = "Mosesland",
                ZipCode = "14157",
                WeekNightPrice = Convert.ToDecimal(90.98),
                WeekendNightPrice = Convert.ToDecimal(172.1),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(18.09),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MO,
                Street = "0835 Angela Station",
                City = "East Heather",
                ZipCode = "26899",
                WeekNightPrice = Convert.ToDecimal(158.64),
                WeekendNightPrice = Convert.ToDecimal(299.91),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(23.09),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.VT,
                Street = "2458 Jason Village Suite 248",
                City = "North Donnamouth",
                ZipCode = "42872",
                WeekNightPrice = Convert.ToDecimal(107.97),
                WeekendNightPrice = Convert.ToDecimal(189.3),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(9.05),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CO,
                Street = "1243 Grimes Corners",
                City = "Shawchester",
                ZipCode = "78301",
                WeekNightPrice = Convert.ToDecimal(214.14),
                WeekendNightPrice = Convert.ToDecimal(193.24),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(26.1),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.DC,
                Street = "558 Williams Station",
                City = "Port Pamela",
                ZipCode = "34523",
                WeekNightPrice = Convert.ToDecimal(106.3),
                WeekendNightPrice = Convert.ToDecimal(192.46),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(17.59),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.VT,
                Street = "4934 Lozano Place Suite 716",
                City = "Gavinton",
                ZipCode = "63064",
                WeekNightPrice = Convert.ToDecimal(116.99),
                WeekendNightPrice = Convert.ToDecimal(257.37),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(5.63),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.LA,
                Street = "41227 Patricia Lake",
                City = "Martinezbury",
                ZipCode = "35700",
                WeekNightPrice = Convert.ToDecimal(203.03),
                WeekendNightPrice = Convert.ToDecimal(108.28),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(11.35),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.VA,
                Street = "028 Harris Drive Apt. 422",
                City = "Amyburgh",
                ZipCode = "55206",
                WeekNightPrice = Convert.ToDecimal(163.3),
                WeekendNightPrice = Convert.ToDecimal(262.77),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(13.74),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IA,
                Street = "06268 Lewis Place Suite 121",
                City = "Port Patriciatown",
                ZipCode = "98240",
                WeekNightPrice = Convert.ToDecimal(156.25),
                WeekendNightPrice = Convert.ToDecimal(108.52),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(23.66),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WI,
                Street = "5641 Brenda Streets Apt. 008",
                City = "Lake Seanmouth",
                ZipCode = "87205",
                WeekNightPrice = Convert.ToDecimal(178.27),
                WeekendNightPrice = Convert.ToDecimal(153.42),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(24.69),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(12),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.ME,
                Street = "92555 Shaw Spurs Suite 207",
                City = "New Randy",
                ZipCode = "58221",
                WeekNightPrice = Convert.ToDecimal(92.51),
                WeekendNightPrice = Convert.ToDecimal(184.92),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(12.82),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NY,
                Street = "559 Foster Locks Suite 933",
                City = "Robinsonhaven",
                ZipCode = "18885",
                WeekNightPrice = Convert.ToDecimal(224.62),
                WeekendNightPrice = Convert.ToDecimal(225.85),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(17.9),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WY,
                Street = "4647 Kristine Fields Suite 710",
                City = "New Dakota",
                ZipCode = "638",
                WeekNightPrice = Convert.ToDecimal(112.61),
                WeekendNightPrice = Convert.ToDecimal(174.02),
                Category = Condo,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(17.48),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.ME,
                Street = "92594 Emily Shoals",
                City = "North Cathyburgh",
                ZipCode = "31451",
                WeekNightPrice = Convert.ToDecimal(189.98),
                WeekendNightPrice = Convert.ToDecimal(119.06),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(25.11),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MS,
                Street = "551 Casey Squares Apt. 209",
                City = "Michaelborough",
                ZipCode = "26297",
                WeekNightPrice = Convert.ToDecimal(72.03),
                WeekendNightPrice = Convert.ToDecimal(114.73),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(18.38),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.PA,
                Street = "2998 Willis Wall",
                City = "North Brian",
                ZipCode = "4610",
                WeekNightPrice = Convert.ToDecimal(216.21),
                WeekendNightPrice = Convert.ToDecimal(144.51),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(10.81),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MD,
                Street = "164 Schultz Road",
                City = "Lake Bryan",
                ZipCode = "86618",
                WeekNightPrice = Convert.ToDecimal(132.69),
                WeekendNightPrice = Convert.ToDecimal(233.9),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(15.8),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.GA,
                Street = "9541 Brock Estate Apt. 848",
                City = "Franklinchester",
                ZipCode = "80124",
                WeekNightPrice = Convert.ToDecimal(220.97),
                WeekendNightPrice = Convert.ToDecimal(285.05),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(20.98),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MS,
                Street = "588 Alan Rest",
                City = "Port Stephanieville",
                ZipCode = "63590",
                WeekNightPrice = Convert.ToDecimal(224.98),
                WeekendNightPrice = Convert.ToDecimal(180.86),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(11.91),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(12),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MT,
                Street = "216 Brandon Loop Apt. 096",
                City = "New Jessica",
                ZipCode = "53548",
                WeekNightPrice = Convert.ToDecimal(221.98),
                WeekendNightPrice = Convert.ToDecimal(239.97),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(9.24),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(12),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.LA,
                Street = "782 Dawn Radial",
                City = "Port Christopher",
                ZipCode = "35611",
                WeekNightPrice = Convert.ToDecimal(76.56),
                WeekendNightPrice = Convert.ToDecimal(297.25),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(20.42),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WA,
                Street = "008 Nancy Route Suite 228",
                City = "North Stephanie",
                ZipCode = "42879",
                WeekNightPrice = Convert.ToDecimal(128.71),
                WeekendNightPrice = Convert.ToDecimal(129.36),
                Category = Condo,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(23.76),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MO,
                Street = "115 Jon Isle Suite 788",
                City = "North Lesliefurt",
                ZipCode = "71569",
                WeekNightPrice = Convert.ToDecimal(114.21),
                WeekendNightPrice = Convert.ToDecimal(210.63),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(21.08),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.DE,
                Street = "132 Poole Pass Suite 212",
                City = "North Patrick",
                ZipCode = "87566",
                WeekNightPrice = Convert.ToDecimal(146.82),
                WeekendNightPrice = Convert.ToDecimal(280.37),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(26.78),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WY,
                Street = "457 Vargas Island Suite 853",
                City = "Lake Patrickstad",
                ZipCode = "67652",
                WeekNightPrice = Convert.ToDecimal(134.72),
                WeekendNightPrice = Convert.ToDecimal(249.39),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(19.19),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.HI,
                Street = "1569 Amy Path",
                City = "North Ashleyton",
                ZipCode = "45184",
                WeekNightPrice = Convert.ToDecimal(111.6),
                WeekendNightPrice = Convert.ToDecimal(111.23),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(13.48),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IL,
                Street = "0375 Sandra Trace Suite 826",
                City = "Gailshire",
                ZipCode = "4078",
                WeekNightPrice = Convert.ToDecimal(89.0),
                WeekendNightPrice = Convert.ToDecimal(168.47),
                Category = Hotel,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(14.93),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MN,
                Street = "759 Good Port",
                City = "New Russell",
                ZipCode = "50437",
                WeekNightPrice = Convert.ToDecimal(208.64),
                WeekendNightPrice = Convert.ToDecimal(208.35),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(7.09),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.WV,
                Street = "3895 Allen Junction",
                City = "West John",
                ZipCode = "34147",
                WeekNightPrice = Convert.ToDecimal(172.51),
                WeekendNightPrice = Convert.ToDecimal(195.41),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(21.53),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MS,
                Street = "7329 Jacobs Station",
                City = "New Tylerborough",
                ZipCode = "36340",
                WeekNightPrice = Convert.ToDecimal(163.15),
                WeekendNightPrice = Convert.ToDecimal(146.12),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(18.98),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(8),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MD,
                Street = "5003 Cassandra Estates Suite 148",
                City = "Haleychester",
                ZipCode = "88806",
                WeekNightPrice = Convert.ToDecimal(81.5),
                WeekendNightPrice = Convert.ToDecimal(161.49),
                Category = Hotel,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(16.41),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.TN,
                Street = "10524 Parker Mall Suite 531",
                City = "Port Courtneyhaven",
                ZipCode = "76853",
                WeekNightPrice = Convert.ToDecimal(177.94),
                WeekendNightPrice = Convert.ToDecimal(120.73),
                Category = Hotel,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(9.5),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MO,
                Street = "300 Madison Stream",
                City = "Christophershire",
                ZipCode = "93533",
                WeekNightPrice = Convert.ToDecimal(121.01),
                WeekendNightPrice = Convert.ToDecimal(187.08),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(16.48),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.FL,
                Street = "4229 Derrick Wells",
                City = "West Tyler",
                ZipCode = "96763",
                WeekNightPrice = Convert.ToDecimal(199.68),
                WeekendNightPrice = Convert.ToDecimal(241.45),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(25.94),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="morales@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.VA,
                Street = "26239 Michael Shoals",
                City = "Gregoryview",
                ZipCode = "92174",
                WeekNightPrice = Convert.ToDecimal(162.01),
                WeekendNightPrice = Convert.ToDecimal(111.91),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(14.35),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IN,
                Street = "302 Joy Spring Apt. 622",
                City = "Ryanhaven",
                ZipCode = "88294",
                WeekNightPrice = Convert.ToDecimal(173.36),
                WeekendNightPrice = Convert.ToDecimal(163.73),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(25.35),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(12),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CA,
                Street = "734 Craig Overpass Suite 589",
                City = "Jefferyside",
                ZipCode = "23464",
                WeekNightPrice = Convert.ToDecimal(216.1),
                WeekendNightPrice = Convert.ToDecimal(287.28),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(22.2),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(8),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CA,
                Street = "272 Green Street",
                City = "Port Lacey",
                ZipCode = "35243",
                WeekNightPrice = Convert.ToDecimal(211.51),
                WeekendNightPrice = Convert.ToDecimal(247.34),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(11.73),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IL,
                Street = "8056 Dunn Trail Apt. 049",
                City = "Blackshire",
                ZipCode = "61935",
                WeekNightPrice = Convert.ToDecimal(111.4),
                WeekendNightPrice = Convert.ToDecimal(189.08),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(19.58),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CA,
                Street = "86187 Antonio Fort",
                City = "North Carmen",
                ZipCode = "72324",
                WeekNightPrice = Convert.ToDecimal(150.69),
                WeekendNightPrice = Convert.ToDecimal(109.87),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(13.3),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(9),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NJ,
                Street = "71318 Cassandra Plaza",
                City = "Burkeview",
                ZipCode = "84393",
                WeekNightPrice = Convert.ToDecimal(184.21),
                WeekendNightPrice = Convert.ToDecimal(227.55),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(19.52),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(7),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NH,
                Street = "5303 Lewis Springs",
                City = "Port Adrian",
                ZipCode = "62346",
                WeekNightPrice = Convert.ToDecimal(204.67),
                WeekendNightPrice = Convert.ToDecimal(207.51),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(26.36),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IA,
                Street = "465 Wiley Corners Apt. 759",
                City = "East Michellechester",
                ZipCode = "2837",
                WeekNightPrice = Convert.ToDecimal(129.14),
                WeekendNightPrice = Convert.ToDecimal(213.84),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(12.81),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.LA,
                Street = "521 Flores Stream",
                City = "West Rebeccaborough",
                ZipCode = "68847",
                WeekNightPrice = Convert.ToDecimal(77.06),
                WeekendNightPrice = Convert.ToDecimal(254.37),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(6.03),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NE,
                Street = "0271 Soto Drives Apt. 975",
                City = "New Edgar",
                ZipCode = "35218",
                WeekNightPrice = Convert.ToDecimal(179.91),
                WeekendNightPrice = Convert.ToDecimal(233.17),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(11.04),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NM,
                Street = "27862 Kent Mountains",
                City = "Lake Michaelville",
                ZipCode = "32697",
                WeekNightPrice = Convert.ToDecimal(90.54),
                WeekendNightPrice = Convert.ToDecimal(153.38),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(6.91),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.OR,
                Street = "917 Mclaughlin Glens",
                City = "Martinville",
                ZipCode = "95889",
                WeekNightPrice = Convert.ToDecimal(225.59),
                WeekendNightPrice = Convert.ToDecimal(226.89),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(28.99),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(2),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rankin@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.KY,
                Street = "3032 Michelle Drives",
                City = "North Daniel",
                ZipCode = "82153",
                WeekNightPrice = Convert.ToDecimal(203.25),
                WeekendNightPrice = Convert.ToDecimal(157.15),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(15.68),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(13),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SD,
                Street = "601 Maria Mission Apt. 554",
                City = "Myerstown",
                ZipCode = "32202",
                WeekNightPrice = Convert.ToDecimal(223.27),
                WeekendNightPrice = Convert.ToDecimal(269.55),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(11.35),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(9),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.OH,
                Street = "238 Shawn Well",
                City = "Port Johnshire",
                ZipCode = "17431",
                WeekNightPrice = Convert.ToDecimal(173.63),
                WeekendNightPrice = Convert.ToDecimal(112.64),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(6.38),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SC,
                Street = "41743 Berger Inlet Apt. 527",
                City = "South Tammymouth",
                ZipCode = "37901",
                WeekNightPrice = Convert.ToDecimal(176.23),
                WeekendNightPrice = Convert.ToDecimal(163.2),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(14.77),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(9),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MO,
                Street = "9983 Mary Grove Apt. 643",
                City = "Beardview",
                ZipCode = "17895",
                WeekNightPrice = Convert.ToDecimal(219.53),
                WeekendNightPrice = Convert.ToDecimal(209.33),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(24.51),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.HI,
                Street = "03541 Ryan Islands Apt. 562",
                City = "East Michaelfort",
                ZipCode = "90576",
                WeekNightPrice = Convert.ToDecimal(126.25),
                WeekendNightPrice = Convert.ToDecimal(269.63),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(8.27),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.SC,
                Street = "6591 Angela Mission Apt. 108",
                City = "Penabury",
                ZipCode = "94980",
                WeekNightPrice = Convert.ToDecimal(143.98),
                WeekendNightPrice = Convert.ToDecimal(286.86),
                Category = Apartment,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(20.48),
                NumberOfBedrooms = Convert.ToInt32(5),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CO,
                Street = "492 Ramirez Crossing",
                City = "Aaronberg",
                ZipCode = "44974",
                WeekNightPrice = Convert.ToDecimal(121.91),
                WeekendNightPrice = Convert.ToDecimal(144.6),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(10.12),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.DE,
                Street = "35974 Sharon Locks Apt. 101",
                City = "Jennyport",
                ZipCode = "66170",
                WeekNightPrice = Convert.ToDecimal(137.8),
                WeekendNightPrice = Convert.ToDecimal(114.46),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(17.74),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(9),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.UT,
                Street = "89403 Gabriella Mills",
                City = "East Steven",
                ZipCode = "22495",
                WeekNightPrice = Convert.ToDecimal(128.63),
                WeekendNightPrice = Convert.ToDecimal(155.1),
                Category = House,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(23.05),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NH,
                Street = "601 Kyle Roads",
                City = "Clarkfurt",
                ZipCode = "85059",
                WeekNightPrice = Convert.ToDecimal(209.11),
                WeekendNightPrice = Convert.ToDecimal(284.39),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(6.25),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(4),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IN,
                Street = "60969 Justin Passage Suite 774",
                City = "Joshuaburgh",
                ZipCode = "61092",
                WeekNightPrice = Convert.ToDecimal(128.59),
                WeekendNightPrice = Convert.ToDecimal(121.0),
                Category = Condo,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(19.36),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.PA,
                Street = "7943 Tina Mount",
                City = "East Lisa",
                ZipCode = "43986",
                WeekNightPrice = Convert.ToDecimal(122.88),
                WeekendNightPrice = Convert.ToDecimal(104.47),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(25.31),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(14),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NC,
                Street = "6775 James Ford",
                City = "South Victorialand",
                ZipCode = "91397",
                WeekNightPrice = Convert.ToDecimal(211.24),
                WeekendNightPrice = Convert.ToDecimal(275.5),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(15.74),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="rice@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.VT,
                Street = "431 Johnson Neck Suite 039",
                City = "Mariechester",
                ZipCode = "67849",
                WeekNightPrice = Convert.ToDecimal(124.65),
                WeekendNightPrice = Convert.ToDecimal(126.24),
                Category = Condo,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(24.3),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NM,
                Street = "15666 Justin Locks",
                City = "Lake Ryanport",
                ZipCode = "20687",
                WeekNightPrice = Convert.ToDecimal(70.11),
                WeekendNightPrice = Convert.ToDecimal(112.05),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(27.45),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="ingram@gmail.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.TX,
                Street = "9947 Torres Viaduct Apt. 506",
                City = "Benjaminport",
                ZipCode = "30222",
                WeekNightPrice = Convert.ToDecimal(174.87),
                WeekendNightPrice = Convert.ToDecimal(152.09),
                Category = Apartment,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(18.44),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(11),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.NJ,
                Street = "20866 Keith Mill",
                City = "Susanton",
                ZipCode = "21190",
                WeekNightPrice = Convert.ToDecimal(96.8),
                WeekendNightPrice = Convert.ToDecimal(174.06),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(28.15),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="jacobs@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.AL,
                Street = "04374 Nicholas Cliff Suite 001",
                City = "Adrianport",
                ZipCode = "4838",
                WeekNightPrice = Convert.ToDecimal(205.01),
                WeekendNightPrice = Convert.ToDecimal(108.24),
                Category = Condo,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(6.56),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(1),
                GuestLimit = Convert.ToInt32(10),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="gonzalez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.CA,
                Street = "271 Andrew Summit",
                City = "Port Craig",
                ZipCode = "80130",
                WeekNightPrice = Convert.ToDecimal(197.52),
                WeekendNightPrice = Convert.ToDecimal(148.39),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(20.55),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MN,
                Street = "17611 Robbins Mission",
                City = "New Curtis",
                ZipCode = "96166",
                WeekNightPrice = Convert.ToDecimal(219.69),
                WeekendNightPrice = Convert.ToDecimal(286.13),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(10.64),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(3),
                GuestLimit = Convert.ToInt32(9),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MO,
                Street = "80831 Kemp Pines",
                City = "Annashire",
                ZipCode = "40702",
                WeekNightPrice = Convert.ToDecimal(91.26),
                WeekendNightPrice = Convert.ToDecimal(123.93),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(19.36),
                NumberOfBedrooms = Convert.ToInt32(1),
                NumberOfBathrooms = Convert.ToInt32(2),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="martinez@aol.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.IL,
                Street = "96545 Smith Alley",
                City = "West Joy",
                ZipCode = "86023",
                WeekNightPrice = Convert.ToDecimal(132.54),
                WeekendNightPrice = Convert.ToDecimal(254.38),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(14.83),
                NumberOfBedrooms = Convert.ToInt32(6),
                NumberOfBathrooms = Convert.ToInt32(8),
                GuestLimit = Convert.ToInt32(7),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MT,
                Street = "6146 Johnson Isle",
                City = "South Arthur",
                ZipCode = "70897",
                WeekNightPrice = Convert.ToDecimal(227.96),
                WeekendNightPrice = Convert.ToDecimal(228.04),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(6.99),
                NumberOfBedrooms = Convert.ToInt32(2),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(1),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="loter@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MN,
                Street = "0415 Smith Springs",
                City = "Jeremyburgh",
                ZipCode = "69154",
                WeekNightPrice = Convert.ToDecimal(140.93),
                WeekendNightPrice = Convert.ToDecimal(228.81),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(29.74),
                NumberOfBedrooms = Convert.ToInt32(4),
                NumberOfBathrooms = Convert.ToInt32(4),
                GuestLimit = Convert.ToInt32(3),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.HI,
                Street = "3999 Ricky Via",
                City = "West Adamburgh",
                ZipCode = "53524",
                WeekNightPrice = Convert.ToDecimal(137.35),
                WeekendNightPrice = Convert.ToDecimal(255.43),
                Category = House,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("True"),
                CleaningFee = Convert.ToDecimal(16.62),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(6),

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="chung@yahoo.com"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.MN,
                Street = "83787 Stuart Key",
                City = "Davetown",
                ZipCode = "24886",
                WeekNightPrice = Convert.ToDecimal(172.99),
                WeekendNightPrice = Convert.ToDecimal(146.75),
                Category = Cabin,
                PetsAllowed = bool.Parse("True"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(26.24),
                NumberOfBedrooms = Convert.ToInt32(7),
                NumberOfBathrooms = Convert.ToInt32(6),
                GuestLimit = Convert.ToInt32(4),
                //Host = db.Users.FirstOrDefault(u => u.UserName == "chung@yahoo.com"))

            });


            AllProperties.Add(new Property
            {

                //populate the user properties that are from the 
                //IdentityUser base class
                Host = db.Users.FirstOrDefault ( u => u.UserName =="tanner@utexas.edu"),

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example

                State = State.TX,
                Street = "690 Christina Park",
                City = "Toddburgh",
                ZipCode = "56713",
                WeekNightPrice = Convert.ToDecimal(188.53),
                WeekendNightPrice = Convert.ToDecimal(157.96),
                Category = Cabin,
                PetsAllowed = bool.Parse("False"),
                FreeParking = bool.Parse("False"),
                CleaningFee = Convert.ToDecimal(6.69),
                NumberOfBedrooms = Convert.ToInt32(3),
                NumberOfBathrooms = Convert.ToInt32(5),
                GuestLimit = Convert.ToInt32(1),

            });

            //create a counter and flag to help with debugging
            int intPropertyID = 0;
            String strPropertyName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artists
                foreach (Property seedProperty in AllProperties)
                {
                    //updates the counters to get info on where the problem is
                    intPropertyID = seedProperty.PropertyID;


                    //try to find the artist in the database
                    Property dbProperty = db.Properties.FirstOrDefault(c => c.PropertyID== seedProperty.PropertyID);

                    //if the artist isn't in the database, dbArtist will be null
                    if (dbProperty == null)
                    {
                        //add the Artist to the database
                        seedProperty.PropertyNumber = Utilities.GenerateNextPropertyNumber.GetNextPropertyNumber(db);
                        db.Properties.Add(seedProperty);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artist because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbProperty.PropertyNumber = seedProperty.PropertyNumber;

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
                msg.Append(strPropertyName);
                msg.Append(" property (PropertyID = ");
                msg.Append(intPropertyID);
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
