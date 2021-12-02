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
                    UserName = "cbaker@freezing.co.uk",
                    Email = "cbaker@freezing.co.uk",
                    PhoneNumber = "5125595133",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Christopher",
                    LastName = "Baker",
                    Birthday = new DateTime(1968, 11, 28),
                    IsActive = true,
                    Address = "1245 Lake America Blvd.",
                    ZipCode = "78733",

                },
                Password = "hellothere",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mb@puppy.com",
                    Email = "mb@puppy.com",
                    PhoneNumber = "2102702860",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Michelle",
                    LastName = "Bradicus",
                    Birthday = new DateTime(1988, 2, 7),
                    IsActive = true,
                    Address = "1300 Small Pine Lane",
                    ZipCode = "78261",

                },
                Password = "555533",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "fd@puppy.com",
                    Email = "fd@puppy.com",
                    PhoneNumber = "8175683686",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Franco",
                    LastName = "Broccoli",
                    Birthday = new DateTime(1999, 11, 07),
                    IsActive = true,
                    Address = "62 Cookie Rd",
                    ZipCode = "77019",

                },
                Password = "666645",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "wendy@puppy.com",
                    Email = "wendy@puppy.com",
                    PhoneNumber = "5125967209",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wendy",
                    LastName = "Charile",
                    Birthday = new DateTime(1992, 10, 27),
                    IsActive = true,
                    Address = "202 Bellmoth Hall",
                    ZipCode = "78713",

                },
                Password = "Kansas",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "limchou@puppy.com",
                    Email = "limchou@puppy.com",
                    PhoneNumber = "2107748586",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lim",
                    LastName = "Chou",
                    Birthday = new DateTime(1961, 11, 11),
                    IsActive = true,
                    Address = "1600 Barbara Lane",
                    ZipCode = "78266",

                },
                Password = "Rockwall",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "444444.Dave@aool.com",
                    Email = "444444.Dave@aool.com",
                    PhoneNumber = "2142667242",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Shan",
                    LastName = "Dave",
                    Birthday = new DateTime(1972, 12, 19),
                    IsActive = true,
                    Address = "234 Puppy Circle",
                    ZipCode = "75208",

                },
                Password = "444444",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "louann@puppy.com",
                    Email = "louann@puppy.com",
                    PhoneNumber = "8172580736",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    Birthday = new DateTime(1958, 8, 1),
                    IsActive = true,
                    Address = "700 S 9th Street W",
                    ZipCode = "77010",

                },
                Password = "longhorns",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tfreeley@puppy.com",
                    Email = "tfreeley@puppy.com",
                    PhoneNumber = "8173279674",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    Birthday = new DateTime(2001, 7, 12),
                    IsActive = true,
                    Address = "4334 Meanview Ave.",
                    ZipCode = "77009",

                },
                Password = "puppies",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mgar@puppy.com",
                    Email = "mgar@puppy.com",
                    PhoneNumber = "8176617531",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    Birthday = new DateTime(1956, 11, 17),
                    IsActive = true,
                    Address = "594 Puppyview",
                    ZipCode = "77003",

                },
                Password = "horses",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    PhoneNumber = "2148499570",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Charles",
                    LastName = "Harley",
                    Birthday = new DateTime(1998, 5, 29),
                    IsActive = true,
                    Address = "One Ranger Pkwy",
                    ZipCode = "75261",

                },
                Password = "mycats",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jeff@puppy.com",
                    Email = "jeff@puppy.com",
                    PhoneNumber = "5127002600",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeffrey",
                    LastName = "Stark",
                    Birthday = new DateTime(1974, 5, 2),
                    IsActive = true,
                    Address = "337 40th St.",
                    ZipCode = "78705",

                },
                Password = "jeffery",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "wjhearniii@umch.edu",
                    Email = "wjhearniii@umch.edu",
                    PhoneNumber = "2148989608",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    LastName = "Hearn",
                    Birthday = new DateTime(1983, 12, 29),
                    IsActive = true,
                    Address = "4445 South First",
                    ZipCode = "75237",

                },
                Password = "posicles",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "hicks43@puppy.com",
                    Email = "hicks43@puppy.com",
                    PhoneNumber = "2105812952",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Mark",
                    LastName = "Hicks",
                    Birthday = new DateTime(1989, 12, 16),
                    IsActive = true,
                    Address = "32 NE Mark Ln., Ste 910",
                    ZipCode = "78239",

                },
                Password = "guac45",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "bradsingram@mall.utexas.edu",
                    Email = "bradsingram@mall.utexas.edu",
                    PhoneNumber = "5124702808",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Brad",
                    LastName = "Ingram",
                    Birthday = new DateTime(1958, 9, 18),
                    IsActive = true,
                    Address = "6548 La Chess St.",
                    ZipCode = "78736",

                },
                Password = "father",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "father.Ingram@aool.com",
                    Email = "father.Ingram@aool.com",
                    PhoneNumber = "5124677352",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    Birthday = new DateTime(1975, 12, 9),
                    IsActive = true,
                    Address = "4564 Palm St.",
                    ZipCode = "78731",

                },
                Password = "555897",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "victoria@puppy.com",
                    Email = "victoria@puppy.com",
                    PhoneNumber = "5129481386",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    Birthday = new DateTime(1981, 5, 29),
                    IsActive = true,
                    Address = "6639 Butterfly Ln.",
                    ZipCode = "78761",

                },
                Password = "something",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "lineback@flush.net",
                    Email = "lineback@flush.net",
                    PhoneNumber = "2102473963",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Brad",
                    LastName = "Lineback",
                    Birthday = new DateTime(1973, 5, 19),
                    IsActive = true,
                    Address = "1300 Pirateland St",
                    ZipCode = "78293",

                },
                Password = "treelover",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",
                    PhoneNumber = "2105368614",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Evan",
                    LastName = "Lowe",
                    Birthday = new DateTime(1993, 6, 7),
                    IsActive = true,
                    Address = "3201 Pineapple Drive",
                    ZipCode = "78279",

                },
                Password = "headear",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "luce_chuck@puppy.com",
                    Email = "luce_chuck@puppy.com",
                    PhoneNumber = "2107007535",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Chuck",
                    LastName = "Luce",
                    Birthday = new DateTime(1995, 6, 11),
                    IsActive = true,
                    Address = "2345 Silent Clouds",
                    ZipCode = "78268",

                },
                Password = "gooseyloosey",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mackcloud@pimpdaddy.com",
                    Email = "mackcloud@pimpdaddy.com",
                    PhoneNumber = "5124772125",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    Birthday = new DateTime(1965, 10, 11),
                    IsActive = true,
                    Address = "2504 Far East Blvd.",
                    ZipCode = "78731",

                },
                Password = "rainyday",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "liz@puppy.com",
                    Email = "liz@puppy.com",
                    PhoneNumber = "5124603832",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    Birthday = new DateTime(1989, 06, 18),
                    IsActive = true,
                    Address = "7861 Chevy Mace Rd",
                    ZipCode = "78732",

                },
                Password = "ember22",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mclarence@puppy.com",
                    Email = "mclarence@puppy.com",
                    PhoneNumber = "8174979188",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Clarence",
                    LastName = "Martin",
                    Birthday = new DateTime(1984, 4, 28),
                    IsActive = true,
                    Address = "87 Alcedo St.",
                    ZipCode = "77045",

                },
                Password = "lamemartin",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "lamemartin.Martin@aool.com",
                    Email = "lamemartin.Martin@aool.com",
                    PhoneNumber = "8178770705",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Gregory",
                    LastName = "Martinez",
                    Birthday = new DateTime(1981, 12, 17),
                    IsActive = true,
                    Address = "8295 Moon Blvd.",
                    ZipCode = "77030",

                },
                Password = "gregory",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "cmiller@mapster.com",
                    Email = "cmiller@mapster.com",
                    PhoneNumber = "8177482602",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Charles",
                    LastName = "Miller",
                    Birthday = new DateTime(1987, 5, 5),
                    IsActive = true,
                    Address = "8962 Side St.",
                    ZipCode = "77031",

                },
                Password = "mucky44",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "nelson.Kelly@puppy.com",
                    Email = "nelson.Kelly@puppy.com",
                    PhoneNumber = "5122950953",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Kelly",
                    LastName = "Nelson",
                    Birthday = new DateTime(1969, 8, 3),
                    IsActive = true,
                    Address = "2601 Green River",
                    ZipCode = "78703",

                },
                Password = "Tree34",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jojoe@puppy.com",
                    Email = "jojoe@puppy.com",
                    PhoneNumber = "2143149884",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Joe",
                    LastName = "Nguyen",
                    Birthday = new DateTime(1956, 2, 6),
                    IsActive = true,
                    Address = "1249 4th NW St.",
                    ZipCode = "75238",

                },
                Password = "jvb485bg",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",
                    PhoneNumber = "2103474912",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Bill",
                    LastName = "O'Reilly",
                    Birthday = new DateTime(1989, 3, 14),
                    IsActive = true,
                    Address = "8800 Gringo Drive",
                    ZipCode = "78260",

                },
                Password = "Bobbygirl",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "or@puppy.com",
                    Email = "or@puppy.com",
                    PhoneNumber = "2142369553",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Anka",
                    LastName = "Radkovich",
                    Birthday = new DateTime(1952, 10, 26),
                    IsActive = true,
                    Address = "1300 Freaky",
                    ZipCode = "75260",

                },
                Password = "radioactive",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",
                    PhoneNumber = "5123768733",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    Birthday = new DateTime(1958, 3, 18),
                    IsActive = true,
                    Address = "4587 Rightfield Rd.",
                    ZipCode = "78707",

                },
                Password = "gopigs",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "erynrice@puppy.com",
                    Email = "erynrice@puppy.com",
                    PhoneNumber = "5123900644",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eryn",
                    LastName = "Rice",
                    Birthday = new DateTime(2000, 11, 2),
                    IsActive = true,
                    Address = "3405 Rio Small",
                    ZipCode = "78705",

                },
                Password = "iloveme",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jorge@hootmail.com",
                    Email = "jorge@hootmail.com",
                    PhoneNumber = "8178928361",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jorge",
                    LastName = "Rodriguez",
                    Birthday = new DateTime(1979, 1, 1),
                    IsActive = true,
                    Address = "6788 Cotten Street",
                    ZipCode = "77057",

                },
                Password = "565656",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",
                    PhoneNumber = "5128776930",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allen",
                    LastName = "Rogers",
                    Birthday = new DateTime(2000, 3, 12),
                    IsActive = true,
                    Address = "4965 Rabbit Hill",
                    ZipCode = "78732",

                },
                Password = "treeman",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "o_st-jean@home.com",
                    Email = "o_st-jean@home.com",
                    PhoneNumber = "2104169665",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Olivier",
                    LastName = "Saint-Jean",
                    Birthday = new DateTime(1997, 5, 1),
                    IsActive = true,
                    Address = "255 Slap Dr.",
                    ZipCode = "78292",

                },
                Password = "55htrq",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ss34@puppy.com",
                    Email = "ss34@puppy.com",
                    PhoneNumber = "5123521797",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Sarah",
                    LastName = "Saunders",
                    Birthday = new DateTime(1994, 5, 31),
                    IsActive = true,
                    Address = "332 Fish C",
                    ZipCode = "78705",

                },
                Password = "leaves",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "willsheff@email.com",
                    Email = "willsheff@email.com",
                    PhoneNumber = "5124534071",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "William",
                    LastName = "Sewell",
                    Birthday = new DateTime(1951, 12, 10),
                    IsActive = true,
                    Address = "2365 34st St.",
                    ZipCode = "78709",

                },
                Password = "borbj44",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "sheff44@puppy.com",
                    Email = "sheff44@puppy.com",
                    PhoneNumber = "5125503154",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    Birthday = new DateTime(1993, 7, 2),
                    IsActive = true,
                    Address = "3886 Road A",
                    ZipCode = "78705",

                },
                Password = "ldiul485",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "johnsmith187@puppy.com",
                    Email = "johnsmith187@puppy.com",
                    PhoneNumber = "2108345875",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    LastName = "Smith",
                    Birthday = new DateTime(1985, 6, 13),
                    IsActive = true,
                    Address = "23 Known Forge Dr.",
                    ZipCode = "78280",

                },
                Password = "kribv75",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "dustroud@mail.com",
                    Email = "dustroud@mail.com",
                    PhoneNumber = "2142370654",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Dustin",
                    LastName = "Stroud",
                    Birthday = new DateTime(1974, 7, 14),
                    IsActive = true,
                    Address = "1212 Henrietta Rd",
                    ZipCode = "75221",

                },
                Password = "klavjkb48",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "eric_stuart@puppy.com",
                    Email = "eric_stuart@puppy.com",
                    PhoneNumber = "5128202322",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eric",
                    LastName = "Stuart",
                    Birthday = new DateTime(1968, 6, 17),
                    IsActive = true,
                    Address = "5576 Big Ring",
                    ZipCode = "78746",

                },
                Password = "vkb451",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",
                    PhoneNumber = "8174584890",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Peter",
                    LastName = "Stump",
                    Birthday = new DateTime(2001, 7, 23),
                    IsActive = true,
                    Address = "1300 Kellen Square",
                    ZipCode = "77018",

                },
                Password = "kdsiu4",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tanner@puppy.com",
                    Email = "tanner@puppy.com",
                    PhoneNumber = "8174614916",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    Birthday = new DateTime(1973, 12, 28),
                    IsActive = true,
                    Address = "4347 Palmstead",
                    ZipCode = "77044",

                },
                Password = "klrfbj45",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "taylordjay@puppy.com",
                    Email = "taylordjay@puppy.com",
                    PhoneNumber = "5124772439",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allison",
                    LastName = "Taylor",
                    Birthday = new DateTime(1999, 9, 30),
                    IsActive = true,
                    Address = "467 Nueces St.",
                    ZipCode = "78705",

                },
                Password = "lraggrhb854",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "lraggrhb854.Taylor@aool.com",
                    Email = "lraggrhb854.Taylor@aool.com",
                    PhoneNumber = "5124536618",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Rachel",
                    LastName = "Taylor",
                    Birthday = new DateTime(1956, 2, 4),
                    IsActive = true,
                    Address = "345 Shortview Dr.",
                    ZipCode = "78705",

                },
                Password = "alsuib95",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tee_frank@hootmail.com",
                    Email = "tee_frank@hootmail.com",
                    PhoneNumber = "8178789530",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Frank",
                    LastName = "Tee",
                    Birthday = new DateTime(1964, 11, 11),
                    IsActive = true,
                    Address = "5590 Big Dr.",
                    ZipCode = "77004",

                },
                Password = "kd1734",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tuck33@puppy.com",
                    Email = "tuck33@puppy.com",
                    PhoneNumber = "2148495141",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Clent",
                    LastName = "Tucker",
                    Birthday = new DateTime(1990, 6, 25),
                    IsActive = true,
                    Address = "3132 Main St.",
                    ZipCode = "75315",

                },
                Password = "kjdb983",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "avelasco@puppy.com",
                    Email = "avelasco@puppy.com",
                    PhoneNumber = "2144009625",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allen",
                    LastName = "Velasco",
                    Birthday = new DateTime(1966, 12, 13),
                    IsActive = true,
                    Address = "634 W. 4th",
                    ZipCode = "75207",

                },
                Password = "odrb02",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "westj@pioneer.net",
                    Email = "westj@pioneer.net",
                    PhoneNumber = "2148499231",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jake",
                    LastName = "West",
                    Birthday = new DateTime(1968, 2, 6),
                    IsActive = true,
                    Address = "RR 3244",
                    ZipCode = "75323",

                },
                Password = "kndl847",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "louielouie@puppy.com",
                    Email = "louielouie@puppy.com",
                    PhoneNumber = "2145674085",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Louis",
                    LastName = "Winthorpe",
                    Birthday = new DateTime(1961, 7, 23),
                    IsActive = true,
                    Address = "2500 Madre Blvd",
                    ZipCode = "78746",

                },
                Password = "lb2394",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "rwood@voyager.net",
                    Email = "rwood@voyager.net",
                    PhoneNumber = "5124569229",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Reagan",
                    LastName = "Wood",
                    Birthday = new DateTime(1988, 10, 24),
                    IsActive = true,
                    Address = "447 Westlake Dr.",
                    ZipCode = "78746",

                },
                Password = "drai494",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jacobs@yahoo.com",
                    Email = "jacobs@yahoo.com",
                    PhoneNumber = "8176663948",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    Birthday = new DateTime(1978,1,29),
                    IsActive = true,
                    Address = "4564 Elm St.",
                    ZipCode = "77003",

                },
                Password = "tj2245",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "rice@yahoo.com",
                    Email = "rice@yahoo.com",
                    PhoneNumber = "2148545987",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eryn",
                    LastName = "Rice",
                    Birthday = new DateTime(2003,6,11),
                    IsActive = true,
                    Address = "3405 Rio Grande",
                    ZipCode = "75261",

                },
                Password = "ricearoni",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ingram@gmail.com",
                    Email = "ingram@gmail.com",
                    PhoneNumber = "5127049017",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    LastName = "Ingram",
                    Birthday = new DateTime(1980,6,25),
                    IsActive = true,
                    Address = "6548 La Posada Ct.",
                    ZipCode = "78705",

                },
                Password = "ingram68",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "martinez@aol.com",
                    Email = "martinez@aol.com",
                    PhoneNumber = "2105859369",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Paul",
                    LastName = "Martinez",
                    Birthday = new DateTime(1969,6,25),
                    IsActive = true,
                    Address = "8295 Sunset Blvd.",
                    ZipCode = "78239",

                },
                Password = "party1",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tanner@utexas.edu",
                    Email = "tanner@utexas.edu",
                    PhoneNumber = "5129527803",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jared",
                    LastName = "Tanner",
                    Birthday = new DateTime(1979,6,2),
                    IsActive = true,
                    Address = "4347 Almstead",
                    ZipCode = "78761",

                },
                Password = "sandman",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "chung@yahoo.com",
                    Email = "chung@yahoo.com",
                    PhoneNumber = "2107053952",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lauren",
                    LastName = "Chung",
                    Birthday = new DateTime(1976,3,24),
                    IsActive = true,
                    Address = "234 RR 12",
                    ZipCode = "78268",

                },
                Password = "listen",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "loter@yahoo.com",
                    Email = "loter@yahoo.com",
                    PhoneNumber = "5124650249",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wandavison",
                    LastName = "Loter",
                    Birthday = new DateTime(1966,9,23),
                    IsActive = true,
                    Address = "3453 RR 3235",
                    ZipCode = "78732",

                },
                Password = "pottery",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "morales@aol.com",
                    Email = "morales@aol.com",
                    PhoneNumber = "8177529019",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Heather",
                    LastName = "Morales",
                    Birthday = new DateTime(1971,1,16),
                    IsActive = true,
                    Address = "4501 RR 140",
                    ZipCode = "77031",

                },
                Password = "heckin",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "rankin@yahoo.com",
                    Email = "rankin@yahoo.com",
                    PhoneNumber = "5122997370",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Martin",
                    LastName = "Rankin",
                    Birthday = new DateTime(1961,5,16),
                    IsActive = true,
                    Address = "340 Second St",
                    ZipCode = "78703",

                },
                Password = "rankmark",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "gonzalez@aol.com",
                    Email = "gonzalez@aol.com",
                    PhoneNumber = "2142415970",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Garth",
                    LastName = "Gonzalez",
                    Birthday = new DateTime(1993,12,10),
                    IsActive = true,
                    Address = "103 Manor Rd",
                    ZipCode = "75260",

                },
                Password = "gg2017",
                RoleName = "Host"
            });
            AllUsers.Add(new AddUserModel()
            { 
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "taylor@bevobnb.com",
                Email = "taylor@bevobnb.com",
                PhoneNumber = "2149036025",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Albert",
                LastName = "Taylor",
                Birthday = new DateTime(1954,8,14),
                IsActive = true,
                Address = "467 Nueces St.",
                ZipCode = "75237",

            },
                Password = "TRY563",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "sheffield@bevobnb.com",
                Email = "sheffield@bevobnb.com",
                PhoneNumber = "5124749225",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Molly",
                LastName = "Sheffield",
                Birthday = new DateTime(1986,8,27),
                IsActive = true,
                Address = "3886 Avenue A",
                ZipCode = "78736",

            },
                Password = "longsnores",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "macleod@bevobnb.com",
                Email = "macleod@bevobnb.com",
                PhoneNumber = "5124723769",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Jenny",
                LastName = "MacLeod",
                Birthday = new DateTime(1984,12,5),
                IsActive = true,
                Address = "2504 Far West Blvd.",
                ZipCode = "78731",

            },
                Password = "kittys",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "rhodes@bevobnb.com",
                Email = "rhodes@bevobnb.com",
                PhoneNumber = "2102520380",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Michelle",
                LastName = "Rhodes",
                Birthday = new DateTime(1972,7,2),
                IsActive = true,
                Address = "4587 Enfield Rd.",
                ZipCode = "78293",

            },
                Password = "puppies",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "stuart@bevobnb.com",
                Email = "stuart@bevobnb.com",
                PhoneNumber = "2105415031",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Evan",
                LastName = "Stuart",
                Birthday = new DateTime(1984,4,17),
                IsActive = true,
                Address = "5576 Toro Ring",
                ZipCode = "78279",

            },
                Password = "coolboi",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "swanson@bevobnb.com",
                Email = "swanson@bevobnb.com",
                PhoneNumber = "5124818542",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Ron",
                LastName = "Swanson",
                Birthday = new DateTime(1991,7,25),
                IsActive = true,
                Address = "245 River Rd",
                ZipCode = "78731",

            },
                Password = "swanbong",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "white@bevobnb.com",
                Email = "white@bevobnb.com",
                PhoneNumber = "8175025605",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Jabriel",
                LastName = "White",
                Birthday = new DateTime(1986,3,17),
                IsActive = true,
                Address = "12 Valley View",
                ZipCode = "77045",

            },
                Password = "456789",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "montgomery@bevobnb.com",
                Email = "montgomery@bevobnb.com",
                PhoneNumber = "8178817122",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Washington",
                LastName = "Montgomery",
                Birthday = new DateTime(1961,5,4),
                IsActive = true,
                Address = "210 Blanco Dr",
                ZipCode = "77030",

            },
                Password = "python4",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "walker@bevobnb.com",
                Email = "walker@bevobnb.com",
                PhoneNumber = "2143196301",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Lisa",
                LastName = "Walker",
                Birthday = new DateTime(2003,4,18),
                IsActive = true,
                Address = "9 Bison Circle",
                ZipCode = "75238",

            },
                Password = "walkameter",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "chang@bevobnb.com",
                Email = "chang@bevobnb.com",
                PhoneNumber = "2103521329",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Gregory",
                LastName = "Chang",
                Birthday = new DateTime(1958,4,26),
                IsActive = true,
                Address = "9003 Joshua St",
                ZipCode = "78260",

            },
                Password = "pupgang",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "derek@bevobnb.com",
                Email = "derek@bevobnb.com",
                PhoneNumber = "5125556789",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Derek",
                LastName = "Dreibrodt",
                Birthday = new DateTime(2001,1,1),
                IsActive = true,
                Address = "4 Privet Dr",
                ZipCode = "78705",

            },
                Password = "2cool4u",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the 
                //IdentityUser base class
                UserName = "rester@bevobnb.com",
                Email = "rester@bevobnb.com",
                PhoneNumber = "2103521329",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Amy",
                LastName = "Rester",
                Birthday = new DateTime(2000,1,1),
                IsActive = true,
                Address = "2110 Speedway",
                ZipCode = "78705",

            },
                Password = "KIzGreat",
                RoleName = "Admin"
            });

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