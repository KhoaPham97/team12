using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Authorize]
    public class BucketsController : Controller
    {
        private cap21t12Entities db = new cap21t12Entities();

        // GET: Buckets
        public ActionResult Index()
        {
            var buckets = db.Buckets.Include(b => b.AspNetUser).Include(b => b.AspNetUser1).Include(b => b.Plan).Include(b => b.Status);
            return View(buckets.ToList());
        }

        // GET: Buckets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bucket bucket = db.Buckets.Find(id);
            if (bucket == null)
            {
                return HttpNotFound();
            }
            return View(bucket);
        }

        // GET: Buckets/Create
        public ActionResult Create()
        {
            ViewBag.Reporter = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.Assignee = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title");
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName");
            return View();
        }

        // POST: Buckets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BucketID,PlanID,StatusID,Assignee,Reporter,Title,Description,StartDate,DueDate")] Bucket bucket)
        {
            if (ModelState.IsValid)
            {
                db.Buckets.Add(bucket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Reporter = new SelectList(db.AspNetUsers, "Id", "Email", bucket.Reporter);
            ViewBag.Assignee = new SelectList(db.AspNetUsers, "Id", "Email", bucket.Assignee);
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title", bucket.PlanID);
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName", bucket.StatusID);
            return View(bucket);
        }

        // GET: Buckets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bucket bucket = db.Buckets.Find(id);
            if (bucket == null)
            {
                return HttpNotFound();
            }
            ViewBag.Reporter = new SelectList(db.AspNetUsers, "Id", "Email", bucket.Reporter);
            ViewBag.Assignee = new SelectList(db.AspNetUsers, "Id", "Email", bucket.Assignee);
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title", bucket.PlanID);
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName", bucket.StatusID);
            return View(bucket);
        }

        // POST: Buckets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BucketID,PlanID,StatusID,Assignee,Reporter,Title,Description,StartDate,DueDate")] Bucket bucket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bucket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Reporter = new SelectList(db.AspNetUsers, "Id", "Email", bucket.Reporter);
            ViewBag.Assignee = new SelectList(db.AspNetUsers, "Id", "Email", bucket.Assignee);
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title", bucket.PlanID);
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName", bucket.StatusID);
            return View(bucket);
        }

        // GET: Buckets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bucket bucket = db.Buckets.Find(id);
            if (bucket == null)
            {
                return HttpNotFound();
            }
            return View(bucket);
        }

        // POST: Buckets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bucket bucket = db.Buckets.Find(id);
            db.Buckets.Remove(bucket);
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
