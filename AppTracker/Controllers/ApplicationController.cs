using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppTracker.Data;
using AppTracker.Models;

namespace AppTracker.Controllers
{
    public class ApplicationController : Controller
    {
        private AppTrackerContext db = new AppTrackerContext();

        // GET: Application
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.PosSortParm = String.IsNullOrEmpty(sortOrder) ? "position_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var applications = from s in db.Applications
                               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                applications = applications.Where(a => a.Position.Contains(searchString)
                                            || a.Company.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "position_desc":
                    applications = applications.OrderByDescending(s => s.Position);
                    break;
                case "Date":
                    applications = applications.OrderBy(s => s.DateApplied);
                    break;
                case "date_desc":
                    applications = applications.OrderByDescending(s => s.DateApplied);
                    break;
                default:
                    applications = applications.OrderBy(s => s.DateApplied);
                    break;
            }
            return View(applications.ToList());
        }

        // GET: Application/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // GET: Application/Create
        public ActionResult Create()
        {
            ViewBag.CompanyID = new SelectList(db.Companies, "ID", "Name");
            return View();
        }

        // POST: Application/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Position,DateApplied,AppliedVia,AppSubmitted,ResSubmitted,CLSubmitted,CompanyID")] Application application)
        {
            if (ModelState.IsValid)
            {
                db.Applications.Add(application);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyID = new SelectList(db.Companies, "ID", "Name", application.CompanyID);
            return View(application);
        }

        // GET: Application/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyID = new SelectList(db.Companies, "ID", "Name", application.CompanyID);
            return View(application);
        }

        // POST: Application/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Position,DateApplied,AppliedVia,AppSubmitted,ResSubmitted,CLSubmitted,CompanyID")] Application application)
        {
            if (ModelState.IsValid)
            {
                db.Entry(application).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyID = new SelectList(db.Companies, "ID", "Name", application.CompanyID);
            return View(application);
        }

        // GET: Application/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // POST: Application/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Application application = db.Applications.Find(id);
            db.Applications.Remove(application);
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
