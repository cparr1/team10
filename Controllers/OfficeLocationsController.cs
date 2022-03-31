using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using team10.DAL;
using team10.Models;

namespace team10.Controllers
{
    public class OfficeLocationsController : Controller
    {
        private Team10Context db = new Team10Context();

        // GET: OfficeLocations
        public ActionResult Index()
        {
            return View(db.OfficeLocation.ToList());
        }

        // GET: OfficeLocations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfficeLocation officeLocation = db.OfficeLocation.Find(id);
            if (officeLocation == null)
            {
                return HttpNotFound();
            }
            return View(officeLocation);
        }

        // GET: OfficeLocations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OfficeLocations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OfficeLocationID,locationName")] OfficeLocation officeLocation)
        {
            if (ModelState.IsValid)
            {
                db.OfficeLocation.Add(officeLocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(officeLocation);
        }

        // GET: OfficeLocations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfficeLocation officeLocation = db.OfficeLocation.Find(id);
            if (officeLocation == null)
            {
                return HttpNotFound();
            }
            return View(officeLocation);
        }

        // POST: OfficeLocations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OfficeLocationID,locationName")] OfficeLocation officeLocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(officeLocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(officeLocation);
        }

        // GET: OfficeLocations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfficeLocation officeLocation = db.OfficeLocation.Find(id);
            if (officeLocation == null)
            {
                return HttpNotFound();
            }
            return View(officeLocation);
        }

        // POST: OfficeLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OfficeLocation officeLocation = db.OfficeLocation.Find(id);
            db.OfficeLocation.Remove(officeLocation);
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
