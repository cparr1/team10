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
    public class UserTitlesController : Controller
    {
        private Team10Context db = new Team10Context();

        // GET: UserTitles
        public ActionResult Index()
        {
            return View(db.UserTitle.ToList());
        }

        // GET: UserTitles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTitle userTitle = db.UserTitle.Find(id);
            if (userTitle == null)
            {
                return HttpNotFound();
            }
            return View(userTitle);
        }

        // GET: UserTitles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserTitles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserTitleID,titleName")] UserTitle userTitle)
        {
            if (ModelState.IsValid)
            {
                db.UserTitle.Add(userTitle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userTitle);
        }

        // GET: UserTitles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTitle userTitle = db.UserTitle.Find(id);
            if (userTitle == null)
            {
                return HttpNotFound();
            }
            return View(userTitle);
        }

        // POST: UserTitles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserTitleID,titleName")] UserTitle userTitle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userTitle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userTitle);
        }

        // GET: UserTitles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTitle userTitle = db.UserTitle.Find(id);
            if (userTitle == null)
            {
                return HttpNotFound();
            }
            return View(userTitle);
        }

        // POST: UserTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserTitle userTitle = db.UserTitle.Find(id);
            db.UserTitle.Remove(userTitle);
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
