using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using fa21team16finalproject.DAL;
using fa21team16finalproject.Models;
using fa21team16finalproject.Utilities;
using static fa21team16finalproject.Models.RegisterViewModel;
using System.Collections.Generic;

namespace fa21team16finalproject.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _context;

        public AccountController(AppDbContext appDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel rvm)
        {
            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid == false)
            {
                //this is the sad path - something went wrong, 
                //return the user to the register page to try again
                return View(rvm);
            }

            //this code maps the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,


                //TODO: Add the rest of the custom user fields here
                //FirstName is included as an example
                FirstName = rvm.FirstName,
                LastName = rvm.LastName,
                Birthday = rvm.Birthday,
                Address = rvm.Address,
                IsActive = true
            };

            //create AddUserModel
            AddUserModel aum = new AddUserModel();
            if (rvm.Role == UserType.Customer)
            {
                aum.User = newUser;
                aum.Password = rvm.Password;
                aum.RoleName = "Customer";
            }
            else if (rvm.Role == UserType.Administrator)
            {
                aum.User = newUser;
                aum.Password = rvm.Password;
                aum.RoleName = "Admin";

                IdentityResult res = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

                if (res.Succeeded) //everything is okay
                {
                    fa21team16finalproject.Utilities.EmailMessaging.SendEmail(rvm.Email, "Congratulations on your new account!", "Welcome to BevoBNB! Your new account has been created.");
                    return RedirectToAction("Index", "Home");
                }
                else  //the add user operation didn't work, and we need to show an error message
                {
                    foreach (IdentityError error in res.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    //send user back to page with errors
                    return View(rvm);
                }
            }
            else
            {
                aum.User = newUser;
                aum.Password = rvm.Password;
                aum.RoleName = "Host";
            }

            //This code uses the AddUser utility to create a new user with the specified password
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded) //everything is okay
            {
                //NOTE: This code logs the user into the account that they just created
                //You may or may not want to log a user in directly after they register - check
                //the business rules!
                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                //Send the user to the home page
                return RedirectToAction("Index", "Home");
            }
            else  //the add user operation didn't work, and we need to show an error message
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send user back to page with errors
                return View(rvm);
            }
        }

        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> AdminControl()
        {
            List<AppUser> admins = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, "Admin") == true)
                {
                    admins.Add(user);
                }
            }
            return View(admins);
        }

        public async Task<IActionResult> ConfirmRehire(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppUser admin = _userManager.Users.FirstOrDefault(u => u.Id == id);

            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }
        public async Task<IActionResult> ConfirmFire(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppUser admin = _userManager.Users.FirstOrDefault(u => u.Id == id);

            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Fire(string id)
        {
            AppUser admin = await _userManager.FindByIdAsync(id);
            admin.IsActive = false;
            _context.Update(admin);
            await _context.SaveChangesAsync();
            List<AppUser> admins = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, "Admin") == true)
                {
                    admins.Add(user);
                }
            }
            return View("AdminControl",admins);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Rehire(string id)
        {
            AppUser admin = await _userManager.FindByIdAsync(id);
            admin.IsActive = true;
            _context.Update(admin);
            await _context.SaveChangesAsync();
            List<AppUser> admins = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, "Admin") == true)
                {
                    admins.Add(user);
                }
            }
            return View("AdminControl",admins);
        }
        // GET: /Account/Login
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl; //pass along the page the user should go back to
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel lvm, string returnUrl)
        {
            //if user forgot to include user name or password,
            //send them back to the login page to try again
            if (ModelState.IsValid == false)
            {
                return View(lvm);
            }

            foreach (AppUser admin in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(admin, "Admin") == true)
                {
                    if (admin.Email == lvm.Email & admin.IsActive == false)
                    {
                        ModelState.AddModelError("", "This admin has been fired, and cannot log in.");
                        return View(lvm);
                    }
                }
            }

            //attempt to sign the user in using the SignInManager
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);

            //if the login worked, take the user to either the url
            //they requested OR the homepage if there isn't a specific url
            if (result.Succeeded)
            {
                //TODO: Figure out how to have customer be directed to properties
                if(User.IsInRole("Customer"))
                {
                    
                    return Redirect(returnUrl ?? "/Properties/Index");
                }
                //return ?? "/" means if returnUrl is null, substitute "/" (home)
                return Redirect(returnUrl ?? "/");
            }
            else //log in was not successful
            {
                //add an error to the model to show invalid attempt
                ModelState.AddModelError("", "Invalid login attempt.");
                //send user back to login page to try again
                return View(lvm);
            }
        }

        //GET: Account/Index
        public IActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();

            //get user info
            String id = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

            //populate the view model
            //(i.e. map the domain model to the view model)
            ivm.Email = user.Email;
            ivm.HasPassword = true;
            ivm.UserID = user.Id;
            ivm.UserName = user.UserName;
            ivm.FirstName = user.FirstName;
            ivm.LastName = user.LastName;
            ivm.Address = user.Address;
            ivm.Birthday = user.Birthday;
            ivm.PhoneNumber = user.PhoneNumber;

            //send data to the view
            return View(ivm);
        }



        //Logic for change password
        // GET: /Account/ChangePassword
        public ActionResult ChangePassword(string id)
        {

            return View();
        }



        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel cpvm, string id)
        {
           
            if (User.IsInRole("Admin"))
            {
                var user = await _userManager.FindByIdAsync(id);
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var psChange = await _userManager.ResetPasswordAsync(user, token, cpvm.NewPassword);
                return RedirectToAction("Index", "Home");
            }
            //if user forgot a field, send them back to 
            //change password page to try again
            if (ModelState.IsValid == false)
            {
                return View(cpvm);
            }

            //Find the logged in user using the UserManager
            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            //Attempt to change the password using the UserManager
            var result = await _userManager.ChangePasswordAsync(userLoggedIn, cpvm.OldPassword, cpvm.NewPassword);

            //if the attempt to change the password worked
            if (result.Succeeded)
            {
                //sign in the user with the new password
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                //send the user back to the home page
                return RedirectToAction("Index", "Home");
            }
            else //attempt to change the password didn't work
            {
                //Add all the errors from the result to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send the user back to the change password page to try again
                return View(cpvm);
            }
        }

        //GET: Views/Account/Edit
        public ActionResult Edit(string id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with id = {id} cannot be found";
                return View("Error");
            }

            var eavm = new EditAccountViewModel
            {
                Id = user.Id,
                NewFirstName = user.FirstName,
                NewLastName = user.LastName,
                NewPhoneNumber = user.PhoneNumber,
                NewAddress = user.Address,
                NewBirthday = user.Birthday

            };
            
            return View(eavm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EditAccountViewModel eavm)
        {
            if (ModelState.IsValid)
            {
                AppUser dbuser = await _userManager.FindByNameAsync(User.Identity.Name);
                dbuser.FirstName = eavm.NewFirstName;
                dbuser.LastName = eavm.NewLastName;
                dbuser.PhoneNumber = eavm.NewPhoneNumber;
                dbuser.Birthday = eavm.NewBirthday;
                dbuser.Address = eavm.NewAddress;

                _context.Users.Update(dbuser);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(eavm);
        }

            //GET:/Account/AccessDenied
            public IActionResult AccessDenied(String ReturnURL)
        {
            return View("Error", new string[] { "Access is denied" });
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            //sign the user out of the application
            _signInManager.SignOutAsync();

            //send the user back to the home page
            return RedirectToAction("Index", "Home");
        }
    }
}