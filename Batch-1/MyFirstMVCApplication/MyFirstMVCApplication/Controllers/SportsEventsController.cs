using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyFirstMVCApplication.Models;

namespace MyFirstMVCApplication.Controllers
{
    public class SportsEventsController : Controller
    {
        private MyModel db = new MyModel();

        // GET: SportsEvents
        public ActionResult Index()
        {
            ViewBag.MyName = "Testing ViewBag";
            ViewBag.Student = new Student() { Name = "Test" };
            ViewData["MyName1"] = "Testing View Data";
            ViewData["MyStudent"]= new Student() { Name = "Test1" };
            TempData["Test1"] = "Hello";
            return View(db.SportsEvents.ToList());
        }

        // GET: SportsEvents/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SportsEvent sportsEvent = db.SportsEvents.Find(id);
            if (sportsEvent == null)
            {
                return HttpNotFound();
            }
            return View(sportsEvent);
        }

        // GET: SportsEvents/Create
        public ActionResult Create()
        {
            string t = TempData["Test1"] as string;
            return View();
        }

        // POST: SportsEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventName,EventDate,EventVenue")] SportsEvent sportsEvent)
        {
            if (ModelState.IsValid)
            {
                string t = TempData["Test1"] as string;
                db.SportsEvents.Add(sportsEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sportsEvent);
        }

        // GET: SportsEvents/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            string t = TempData["Test1"] as string;
            SportsEvent sportsEvent = db.SportsEvents.Find(id);
            if (sportsEvent == null)
            {
                return HttpNotFound();
            }
            return View(sportsEvent);
        }

        // POST: SportsEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventName,EventDate,EventVenue")] SportsEvent sportsEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sportsEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sportsEvent);
        }

        // GET: SportsEvents/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SportsEvent sportsEvent = db.SportsEvents.Find(id);
            if (sportsEvent == null)
            {
                return HttpNotFound();
            }
            return View(sportsEvent);
        }

        // POST: SportsEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SportsEvent sportsEvent = db.SportsEvents.Find(id);
            db.SportsEvents.Remove(sportsEvent);
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
