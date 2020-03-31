using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Hotel_Reservation_SystemProject.Models;







namespace Hotel_Reservation_SystemProject.Controllers

{

    public class RegisterController : Controller

    {

        private ProjectContext db = new ProjectContext();

        


        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Register userr)
        {
            //if (ModelState.IsValid)  
            //{  
            if (IsValid(userr.Email, userr.Password))
            {
                FormsAuthentication.SetAuthCookie(userr.Email, false);
                return RedirectToAction("Search1", "Bookings");
            }
            else
            {
                ModelState.AddModelError("", "Login details are wrong.");
            }
            return View(userr);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Register(Register user)
        {

            if (ModelState.IsValid)
            {
                using (var db = new ProjectContext())
                {
                    var crypto = new SimpleCrypto.PBKDF2();
                    var encrypPass = crypto.Compute(user.Password);
                    var newUser = db.Registrations.Create();
                    newUser.Email = user.Email;
                    newUser.Password = encrypPass;
                    newUser.PasswordSalt = crypto.Salt;
                    newUser.FirstName = user.FirstName;
                    newUser.LastName = user.LastName;
                    newUser.UserType = "User";
                    newUser.CreatedDate = DateTime.Now;
                    newUser.IsActive = true;
                    newUser.IPAddress = "642 White Hague Avenue";
                    newUser.ValidId = user.ValidId;
                    newUser.Phone = user.Phone;
                    newUser.Address = user.Address;
                    db.Registrations.Add(newUser);

                    db.SaveChanges();
                    return RedirectToAction("Login", "Register");

                }

            }
            else
            {
                ModelState.AddModelError("", "Data is not correct");
            }

   
         return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogOut", "Register");
        }

        private bool IsValid(string email, string password)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            bool IsValid = false;

            using (var db = new ProjectContext())
            {
                var user = db.Registrations.FirstOrDefault(u => u.Email == email);
                if (user != null)
                {
                    if (user.Password == crypto.Compute(password, user.PasswordSalt))
                    {
                        IsValid = true;
                    }
                }
            }
            return IsValid;
        }





        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(admin userr)
        {
            //if (ModelState.IsValid)  
            //{  
            if (IsValid(userr.Email, userr.Password))
            {
                FormsAuthentication.SetAuthCookie(userr.Email, false);
                return RedirectToAction("Search", "Bookings");
            }
            else
            {
                ModelState.AddModelError("", "Login details are wrong.");
            }
            return View(userr);
        }




        [HttpGet]
        public ActionResult adminregister()
        {
            return View();
        }




        [HttpPost]
        public ActionResult adminregister(admin user)
        {

            if (ModelState.IsValid)
            {
                using (var db = new ProjectContext())
                {
                    var crypto = new SimpleCrypto.PBKDF2();
                    var encrypPass = crypto.Compute(user.Password);
                    var newUser = db.Registrations.Create();
                    newUser.Email = user.Email;
                    newUser.Password = encrypPass;
                    newUser.PasswordSalt = crypto.Salt;
                    newUser.FirstName = user.FirstName;
                    newUser.LastName = user.LastName;
                    newUser.UserType = "User";
                    newUser.CreatedDate = DateTime.Now;
                    newUser.IsActive = true;
                    newUser.IPAddress = "642 White Hague Avenue";
                    newUser.ValidId = user.ValidId;
                    newUser.Phone = user.Phone;
                    newUser.Address = user.Address;
                    db.Registrations.Add(newUser);

                    db.SaveChanges();
                    return RedirectToAction("AdminLogin", "Register");

                }

            }
            else
            {
                ModelState.AddModelError("", "Data is not correct");
            }


            return View();
        }

    }

}