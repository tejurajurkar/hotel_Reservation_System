﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hotel_Reservation_SystemProject.Models;

namespace Hotel_Reservation_SystemProject.Controllers
{
    public class BookingsController : Controller
    {
         ProjectContext db = new ProjectContext();

        // GET: Bookings
        public ActionResult Index()
        {
            return View(db.bookings.ToList());
        }

        [HttpGet]
        public ActionResult booking()

        {

            return View();

        }
        public ActionResult CashPay()

        {

            return View();

        }
        public ActionResult Payment()

        {

            return View();

        }


        [HttpPost]

        public ViewResult booking(Booking guestResponse)

        {


            if (ModelState.IsValid)
            {


                using (var context = new ProjectContext())

                {
                   
                    context.bookings.Add(guestResponse);

                    context.SaveChanges();
                    return View("Payment");

                }
            }

         
            else

            {

                ModelState.AddModelError("", "Data is not correct");

            }


            return View();

        }


        public ActionResult Search(string option, string search)

        {

            if (option == "roomtype")

            {

                return View(db.bookings.Where(x => x.roomtype == search || search == null).ToList());

                



            }

            else

            {

                return View(db.bookings.Where(x => x.checkin.StartsWith(search) || search == null).ToList());

           

            }

            //else

       

        }



        public ActionResult Search1(string option, string search)

        {

            if (option == "roomtype")

            {

                return View(db.bookings.Where(x => x.roomtype == search || search == null).ToList());





            }

            else

            {

                return View(db.bookings.Where(x => x.checkin.StartsWith(search) || search == null).ToList());



            }

            //else



        }


        // GET: Bookings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // GET: Bookings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "bookingid,Name,Email,roomtype,checkin,noofnight")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                db.bookings.Add(booking);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(booking);
        }

        // GET: Bookings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "bookingid,Name,Email,roomtype,checkin,noofnight")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(booking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Booking booking = db.bookings.Find(id);
            db.bookings.Remove(booking);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}