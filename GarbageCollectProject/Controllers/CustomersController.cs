using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GarbageCollectProject.Models;
using Microsoft.AspNet.Identity;

namespace GarbageCollectProject.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customers
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.ApplicationId = User.Identity.GetUserId();
                customer.WeeklyCharge = 10;
                customer.Balance = 0;
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id")] Customer customer)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(customer).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(customer);
        //}
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                Customer editCustomer = db.Customers.Find(id);
                editCustomer.FirstName = customer.FirstName;
                editCustomer.LastName = customer.LastName;
                editCustomer.StreetAddress = customer.StreetAddress;
                editCustomer.ZipCode = customer.ZipCode;
                editCustomer.OneTimePickupDate = customer.OneTimePickupDate;
                editCustomer.WeeklyPickupDay = customer.WeeklyPickupDay;
                editCustomer.HoldPickupStart = customer.HoldPickupStart;
                editCustomer.HoldPickupEnd = customer.HoldPickupEnd;
                db.SaveChanges();
                return RedirectToAction("Details", "Customers", new { id = editCustomer.Id });
            }
            catch
            {
                return View();
            }
        }


        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
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

        //edit pickup


        
        
        public ActionResult EditPickup()
        {
            string userId = User.Identity.GetUserId();
            Customer customer = db.Customers.FirstOrDefault(c => c.ApplicationId == userId);
            return View(customer);
             
        }
        [HttpPost]
        public ActionResult Details(Customer customer)
        {
            Customer foundCustomer = db.Customers.Where(c => c.UserName == customer.UserName).FirstOrDefault();
            foundCustomer.NextPickup = DateTime.Today.AddDays(7);
            foundCustomer.LastPickup = DateTime.Today;
            foundCustomer.Balance += foundCustomer.WeeklyCharge;
            db.SaveChanges();

            return View(customer);
        }




        //One Time Pick-up


        //check balance


    }
}
