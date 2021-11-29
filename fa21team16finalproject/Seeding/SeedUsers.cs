using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

using fa21team16finalproject.Models;
using fa21team16finalproject.Utilities;
using fa21team16finalproject.DAL;
using System.Threading.Tasks;

namespace fa21team16finalproject.Seeding
{
    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "admin@example.com",
                    Email = "admin@example.com",
                    PhoneNumber = "(512)555-1234",

                    //FirstName is included as an example
                    FirstName = "Admin",
                    LastName = "MIS",
                    Birthday = new DateTime(1988, 5, 1, 8, 30, 52),
                    Address = "1105 Carronton Drive"
            },
                Password = "Abc123!",
                RoleName = "Admin"
            });
            /*
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "bevo@example.com",
                    Email = "bevo@example.com",
                    PhoneNumber = "(512)555-5555",

                    //FirstName is included as an example
                    FirstName = "Bevo",
                    LastName = "UT"
                },
                Password = "Password123!",
                RoleName = "Customer"
            });
            */
            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + errorFlag, ex);
            }

            return result;
        }
    }
}