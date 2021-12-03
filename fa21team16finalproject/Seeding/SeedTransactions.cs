using fa21team16finalproject.DAL;
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

        public static class SeedTransactions
        {
            public static void SeedAllTransactions(AppDbContext db)
            {
                List<Reservation> AllReservations = new List<Reservation>();
            List<Order> AllOrders = new List<Order>();


            AllReservations.Add(new Reservation
            {
                Property = db.Properties.FirstOrDefault(p => p.City == " Lake Michael"),
                Customer = db.Users.FirstOrDefault(u => u.UserName == "fd@puppy.com"),
                WeekendNightPrice = 139.83m,
                WeekNightPrice = 155.03m,
                CleaningFee = 21.05m,
                CheckInDate = new DateTime(2019, 05, 12),
                CheckOutDate = new DateTime(2019, 05, 18),
                DiscountDays = (int)4.0,
                PercentDiscount = (decimal)0.15,
                Status = Status.Confirmed,
                ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)

            }); ;


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Lake Michael"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                    WeekendNightPrice = 139.83m,
                    WeekNightPrice = 155.03m,
                    CleaningFee = 21.05m,
                    CheckInDate = new DateTime(2020, 12, 01),
                    CheckOutDate = new DateTime(2020, 12, 02),
                    DiscountDays = (int)4.0,
                    PercentDiscount = (decimal)0.15,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Lake Michael"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "ra@aoo.com"),
                    WeekendNightPrice = 139.83m,
                    WeekNightPrice = 155.03m,
                    CleaningFee = 21.05m,
                    CheckInDate = new DateTime(2019, 09, 08),
                    CheckOutDate = new DateTime(2019, 09, 10),
                    DiscountDays = (int)4.0,
                    PercentDiscount = (decimal)0.15,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Lake Michael"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "tfreeley@puppy.com"),
                    WeekendNightPrice = 139.83m,
                    WeekNightPrice = 155.03m,
                    CleaningFee = 21.05m,
                    CheckInDate = new DateTime(2021, 02, 02),
                    CheckOutDate = new DateTime(2021, 02, 11),
                    DiscountDays = (int)4.0,
                    PercentDiscount = (decimal)0.15,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Chelsealand"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "tuck33@puppy.com"),
                    WeekendNightPrice = 286.53m,
                    WeekNightPrice = 163.68m,
                    CleaningFee = 25.57m,
                    CheckInDate = new DateTime(2018, 04, 04),
                    CheckOutDate = new DateTime(2018, 04, 05),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Port Trevor"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                    WeekendNightPrice = 278.17m,
                    WeekNightPrice = 194.84m,
                    CleaningFee = 5.88m,
                    CheckInDate = new DateTime(2021, 06, 19),
                    CheckOutDate = new DateTime(2021, 06, 30),
                    DiscountDays = (int)7.0,
                    PercentDiscount = (decimal)0.4,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Port Trevor"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "sheff44@puppy.com"),
                    WeekendNightPrice = 278.17m,
                    WeekNightPrice = 194.84m,
                    CleaningFee = 5.88m,
                    CheckInDate = new DateTime(2017, 07, 07),
                    CheckOutDate = new DateTime(2017, 07, 27),
                    DiscountDays = (int)7.0,
                    PercentDiscount = (decimal)0.4,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Port Trevor"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "jorge@hootmail.com"),
                    WeekendNightPrice = 278.17m,
                    WeekNightPrice = 194.84m,
                    CleaningFee = 5.88m,
                    CheckInDate = new DateTime(2021, 01, 03),
                    CheckOutDate = new DateTime(2021, 01, 14),
                    DiscountDays = (int)7.0,
                    PercentDiscount = (decimal)0.4,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " West Haleyburgh"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "fd@puppy.com"),
                    WeekendNightPrice = 182.77m,
                    WeekNightPrice = 127.97m,
                    CleaningFee = 13.02m,
                    CheckInDate = new DateTime(2021, 05, 02),
                    CheckOutDate = new DateTime(2021, 05, 05),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " West Haleyburgh"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "tuck33@puppy.com"),
                    WeekendNightPrice = 182.77m,
                    WeekNightPrice = 127.97m,
                    CleaningFee = 13.02m,
                    CheckInDate = new DateTime(2021, 11, 28),
                    CheckOutDate = new DateTime(2021, 12, 13),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " New Sandra"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                    WeekendNightPrice = 172.79m,
                    WeekNightPrice = 229.03m,
                    CleaningFee = 14.05m,
                    CheckInDate = new DateTime(2019, 01, 03),
                    CheckOutDate = new DateTime(2019, 01, 11),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Florestown"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "father.Ingram@aool.com"),
                    WeekendNightPrice = 128.05m,
                    WeekNightPrice = 83.34m,
                    CleaningFee = 11.29m,
                    CheckInDate = new DateTime(2021, 07, 18),
                    CheckOutDate = new DateTime(2021, 07, 30),
                    DiscountDays = (int)5.0,
                    PercentDiscount = (decimal)0.25,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Florestown"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "fd@puppy.com"),
                    WeekendNightPrice = 128.05m,
                    WeekNightPrice = 83.34m,
                    CleaningFee = 11.29m,
                    CheckInDate = new DateTime(2015, 03, 04),
                    CheckOutDate = new DateTime(2015, 03, 20),
                    DiscountDays = (int)5.0,
                    PercentDiscount = (decimal)0.25,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Florestown"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "ra@aoo.com"),
                    WeekendNightPrice = 128.05m,
                    WeekNightPrice = 83.34m,
                    CleaningFee = 11.29m,
                    CheckInDate = new DateTime(2021, 07, 01),
                    CheckOutDate = new DateTime(2021, 07, 04),
                    DiscountDays = (int)5.0,
                    PercentDiscount = (decimal)0.25,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Florestown"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "tfreeley@puppy.com"),
                    WeekendNightPrice = 128.05m,
                    WeekNightPrice = 83.34m,
                    CleaningFee = 11.29m,
                    CheckInDate = new DateTime(2021, 08, 15),
                    CheckOutDate = new DateTime(2021, 08, 28),
                    DiscountDays = (int)5.0,
                    PercentDiscount = (decimal)0.25,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " New Randy"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "lamemartin.Martin@aool.com"),
                    WeekendNightPrice = 184.92m,
                    WeekNightPrice = 92.51m,
                    CleaningFee = 12.82m,
                    CheckInDate = new DateTime(2021, 11, 26),
                    CheckOutDate = new DateTime(2021, 12, 07),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Port Stephanieville"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "father.Ingram@aool.com"),
                    WeekendNightPrice = 180.86m,
                    WeekNightPrice = 224.98m,
                    CleaningFee = 11.91m,
                    CheckInDate = new DateTime(2021, 10, 04),
                    CheckOutDate = new DateTime(2021, 10, 06),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Port Stephanieville"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                    WeekendNightPrice = 180.86m,
                    WeekNightPrice = 224.98m,
                    CleaningFee = 11.91m,
                    CheckInDate = new DateTime(2021, 11, 29),
                    CheckOutDate = new DateTime(2021, 12, 10),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Port Stephanieville"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "tuck33@puppy.com"),
                    WeekendNightPrice = 180.86m,
                    WeekNightPrice = 224.98m,
                    CleaningFee = 11.91m,
                    CheckInDate = new DateTime(2018, 09, 14),
                    CheckOutDate = new DateTime(2018, 09, 16),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " North Patrick"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                    WeekendNightPrice = 280.37m,
                    WeekNightPrice = 146.82m,
                    CleaningFee = 26.78m,
                    CheckInDate = new DateTime(2018, 11, 25),
                    CheckOutDate = new DateTime(2018, 12, 07),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Lake Patrickstad"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "lamemartin.Martin@aool.com"),
                    WeekendNightPrice = 249.39m,
                    WeekNightPrice = 134.72m,
                    CleaningFee = 19.19m,
                    CheckInDate = new DateTime(2021, 11, 11),
                    CheckOutDate = new DateTime(2021, 11, 13),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Lake Patrickstad"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                    WeekendNightPrice = 249.39m,
                    WeekNightPrice = 134.72m,
                    CleaningFee = 19.19m,
                    CheckInDate = new DateTime(2017, 10, 07),
                    CheckOutDate = new DateTime(2017, 10, 10),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Lake Patrickstad"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "sheff44@puppy.com"),
                    WeekendNightPrice = 249.39m,
                    WeekNightPrice = 134.72m,
                    CleaningFee = 19.19m,
                    CheckInDate = new DateTime(2018, 08, 18),
                    CheckOutDate = new DateTime(2018, 08, 28),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " Martinville"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                    WeekendNightPrice = 226.89m,
                    WeekNightPrice = 225.59m,
                    CleaningFee = 28.99m,
                    CheckInDate = new DateTime(2018, 09, 21),
                    CheckOutDate = new DateTime(2018, 09, 26),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " North Daniel"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "lamemartin.Martin@aool.com"),
                    WeekendNightPrice = 157.15m,
                    WeekNightPrice = 203.25m,
                    CleaningFee = 15.68m,
                    CheckInDate = new DateTime(2019, 04, 04),
                    CheckOutDate = new DateTime(2019, 04, 13),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " East Michaelfort"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "father.Ingram@aool.com"),
                    WeekendNightPrice = 269.63m,
                    WeekNightPrice = 126.25m,
                    CleaningFee = 8.27m,
                    CheckInDate = new DateTime(2020, 01, 01),
                    CheckOutDate = new DateTime(2020, 01, 05),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });


                AllReservations.Add(new Reservation
                {
                    Property = db.Properties.FirstOrDefault(p => p.City == " East Michaelfort"),
                    Customer = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com"),
                    WeekendNightPrice = 269.63m,
                    WeekNightPrice = 126.25m,
                    CleaningFee = 8.27m,
                    CheckInDate = new DateTime(2020, 04, 01),
                    CheckOutDate = new DateTime(2020, 04, 04),
                    DiscountDays = (int)0.0,
                    PercentDiscount = (decimal)0.0,
                    Status = Status.Confirmed,
                    ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(db)
                });

                foreach (Reservation rsv in AllReservations)
                {
                List<Reservation> Reservations = new List<Reservation>();
                Reservations.Add(rsv);
                AllOrders.Add(new Order
                {
                    Status = Status.Confirmed,
                    Reservations = Reservations,
                    AppUser = db.Users.FirstOrDefault(u => u.UserName == rsv.Customer.UserName),
                    OrderDate = DateTime.Now,
                    ConfirmationNumber = rsv.ConfirmationNumber,

                }) ;
                Reservations.Clear();
                }
                //create a counter and flag to help with debugging
                int intReservationID = 0;

                //we are now going to add the data to the database
                //this could cause errors, so we need to put this code
                //into a Try/Catch block
                try
                {
                    //loop through each of the artists
                    foreach (Reservation seedReservation in AllReservations)
                    {
                        //updates the counters to get info on where the problem is
                        intReservationID = seedReservation.ReservationID;

                        //try to find the artist in the database
                        Reservation dbReservation = db.Reservations.FirstOrDefault(c => c.ReservationID == seedReservation.ReservationID);

                        //if the artist isn't in the database, dbArtist will be null
                        if (dbReservation == null)
                        {
                            //add the Artist to the database
                            db.Reservations.Add(seedReservation);
                            db.SaveChanges();
                        }
                        else //the record is in the database
                        {
                            //update all the fields
                            //this isn't really needed for artist because it only has one field
                            //but you will need it to re-set seeded data with more fields
                            dbReservation.ReservationID = seedReservation.ReservationID;

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
                    msg.Append(" Reservation (ReservationID = ");
                    msg.Append(intReservationID);
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
