using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;







namespace WebApplication2.Controllers

{

    public class RegisterController : Controller

    {

        private ProjectContext db = new ProjectContext();

        // GET: Register

        public ActionResult Register()

        {

            return View();

        }



        public ActionResult Login()

        {

            return View();

        }







        [HttpPost]

        public ViewResult Register(Register guestResponse)

        {

            if (ModelState.IsValid)

            {

                using (var context = new ProjectContext())

                {

                    context.Registrations.Add(guestResponse);

                    context.SaveChanges();

                }

                return View("Login", guestResponse);

            }

            else

            {

                return View();

            }



        }





        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Login(Register objUser)

        {

            if (ModelState.IsValid)

            {

                using (var context = new ProjectContext())

                {

                    var obj = context.Registrations.Where(a => a.UserName.Equals(objUser.UserName)

                    && a.Pass.Equals(objUser.Pass)).FirstOrDefault();

                    if (obj != null)

                    {

                        Session["UserID"] = obj.ID.ToString();

                        Session["UserName"] = obj.Pass.ToString();

                        return RedirectToAction("Register");

                    }

                }

            }

            return View(objUser);

        }

        public ActionResult adminregister()

        {

            return View();

        }

        public ActionResult AdminLogin()

        {

            return View();

        }



        [HttpPost]

        public ViewResult adminregister(admin an)

        {

            if (ModelState.IsValid)

            {

                using (var context = new ProjectContext())

                {

                    context.Admin.Add(an);

                    context.SaveChanges();

                }

                return View("AdminLogin", an);

            }

            else

            {

                return View();

            }



        }





        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult AdminLogin(admin objUser)

        {

            if (ModelState.IsValid)

            {

                using (var context = new ProjectContext())

                {

                    var obj = context.Admin.Where(a => a.adminname.Equals(objUser.adminname)

                    && a.pass.Equals(objUser.pass)).FirstOrDefault();

                    if (obj != null)

                    {

                        Session["UserID"] = obj.adminid.ToString();

                        Session["UserName"] = obj.pass.ToString();

                        return RedirectToAction("adminregister");

                    }

                }

            }

            return View(objUser);

        }









    }

}