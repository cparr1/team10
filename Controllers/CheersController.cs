using Microsoft.AspNet.Identity;
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
    public class CheersController : Controller
    {
        private Team10Context db = new Team10Context();

        // GET: Cheers
        public ActionResult Index()
        {
            var cheer = db.Cheer.Include(c => c.CheerReciever).Include(c => c.CheerSender);
            return View(cheer.ToList());
        }

        // GET: Cheers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cheer cheer = db.Cheer.Find(id);
            if (cheer == null)
            {
                return HttpNotFound();
            }
            return View(cheer);
        }

        // GET: Cheers/Create
        [Authorize]
        public ActionResult Create()
        {
            string empID = User.Identity.GetUserId();
            SelectList CheerGetter = new SelectList(db.CentricUser, "CentricUserID", "fullName");
            CheerGetter = new SelectList(CheerGetter.Where(x => x.Value != empID).ToList(), "Value", "Text");
            ViewBag.CheerGetter = CheerGetter;
            return View();
        }

        // POST: Cheers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CheerID,CentricUserID,CheerGetter,ShortDesc,CoreValueCheered")] Cheer cheer)
        {
            if (ModelState.IsValid)
            {
                Guid memberID;
                Guid.TryParse(User.Identity.GetUserId(), out memberID);
                cheer.CentricUserID = memberID;
                db.Cheer.Add(cheer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CheerGetter = new SelectList(db.CentricUser, "CentricUserID", "fullName", cheer.CheerGetter);
            ViewBag.CentricUserID = new SelectList(db.CentricUser, "CentricUserID", "fullName", cheer.CentricUserID);
            return View(cheer);
        }

        // GET: Cheers/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cheer cheer = db.Cheer.Find(id);
            if (cheer == null)
            {
                return HttpNotFound();
            }
            ViewBag.CheerGetter = new SelectList(db.CentricUser, "CentricUserID", "fullName", cheer.CheerGetter);
            ViewBag.CentricUserID = new SelectList(db.CentricUser, "CentricUserID", "fullName", cheer.CentricUserID);
            return View(cheer);
        }

        // POST: Cheers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "CheerID,CentricUserID,CheerGetter,ShortDesc,CoreValueCheered")] Cheer cheer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cheer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CheerGetter = new SelectList(db.CentricUser, "CentricUserID", "fullName", cheer.CheerGetter);
            ViewBag.CentricUserID = new SelectList(db.CentricUser, "CentricUserID", "fullName", cheer.CentricUserID);
            return View(cheer);
        }

        // GET: Cheers/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cheer cheer = db.Cheer.Find(id);
            if (cheer == null)
            {
                return HttpNotFound();
            }
            return View(cheer);
        }

        // POST: Cheers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Cheer cheer = db.Cheer.Find(id);
            db.Cheer.Remove(cheer);
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
