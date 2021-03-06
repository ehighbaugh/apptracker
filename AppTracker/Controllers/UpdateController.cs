﻿using System;
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
    public class UpdateController : Controller
    {
        private AppTrackerContext db = new AppTrackerContext();

        // GET: Update
        public ActionResult Index(string sortOrder, string searchString)
        {
            var updates = db.Updates.Include(u => u.Application);

            ViewBag.PosSortParm = String.IsNullOrEmpty(sortOrder) ? "pos_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            if (!String.IsNullOrEmpty(searchString))
            {
                updates = updates.Where(u => u.Application.Position.Contains(searchString) || u.Application.Company.Name.Contains(searchString) );
            }

            switch (sortOrder)
            {
                case "pos_desc":
                    updates = updates.OrderByDescending(a => a.Application.Position);
                    break;
                case "Date":
                    updates = updates.OrderBy(a => a.Date);
                    break;
                case "date_desc":
                    updates = updates.OrderByDescending(a => a.Date);
                    break;
                default:
                    updates = updates.OrderBy(a => a.Application.Position);
                    break;
            }

            return View(updates.ToList());
        }

        // GET: Update/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Update update = db.Updates.Find(id);
            if (update == null)
            {
                return HttpNotFound();
            }
            return View(update);
        }

        // GET: Update/Create
        public ActionResult Create()
        {
            ViewBag.ApplicationID = new SelectList(db.Applications, "ApplicationID", "Position");
            return View();
        }

        // POST: Update/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UpdateID,Date,Subject,Note,CompanyID,ApplicationID")] Update update)
        {
            if (ModelState.IsValid)
            {
                db.Updates.Add(update);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ApplicationID = new SelectList(db.Applications, "ApplicationID", "Position", update.ApplicationID);
            return View(update);
        }

        // GET: Update/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Update update = db.Updates.Find(id);
            if (update == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicationID = new SelectList(db.Applications, "ApplicationID", "Position", update.ApplicationID);
            return View(update);
        }

        // POST: Update/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UpdateID,Date,Subject,Note,CompanyID,ApplicationID")] Update update)
        {
            if (ModelState.IsValid)
            {
                db.Entry(update).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicationID = new SelectList(db.Applications, "ApplicationID", "Position", update.ApplicationID);
            return View(update);
        }

        // GET: Update/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Update update = db.Updates.Find(id);
            if (update == null)
            {
                return HttpNotFound();
            }
            return View(update);
        }

        // POST: Update/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Update update = db.Updates.Find(id);
            db.Updates.Remove(update);
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
