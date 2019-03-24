﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Authorize]
    public class TasksController : Controller
    {
        private cap21t12Entities db = new cap21t12Entities();

        // GET: Tasks
        public ActionResult Index()
        {
            var tasks1 = db.Tasks.Include(t => t.AspNetUser).Include(t => t.AspNetUser1).Include(t => t.Bucket).Include(t => t.Status);
            return View(tasks1.ToList());
        }
        public ActionResult Management(int? id)
        {


            var a = db.Plans.Where(x => x.IDPlan == id);
            var b = db.Tasks.Where(x => x.BucketID == id);
            ViewBag.Test = db.Tasks.ToList().Where(x => x.BucketID == id);
            ViewBag.Message = a;
            ViewBag.Bucket = db.Buckets;
            ViewBag.Assignee = db.AspNetUsers;
            ViewBag.Status = db.Status;
            var model = db.Tasks.ToList().Where(x => x.BucketID == id);
            return View(model);
        }
        public ActionResult MyTask()
        {
            var product = db.Tasks.ToList().Where(p => p.AssigneeID == User.Identity.GetUserId());
            return View(product);
        }
        // GET: Tasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task tasks = db.Tasks.Find(id);
            if (tasks == null)
            {
                return HttpNotFound();
            }
            return View(tasks);
        }

        // GET: Tasks/Create
        public ActionResult Create(int? id)
        {
         
            ViewBag.AssigneeID = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.ReporterID = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.BucketID = new SelectList(db.Buckets, "BucketID", "Title");
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName");
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaskID,BucketID,StatusID,AssigneeID,ReporterID,Title,Description,Startdate,Duedate")] Task tasks)
        {
            if (ModelState.IsValid)
            {
                db.Tasks.Add(tasks);
                db.SaveChanges();
                return Redirect(Request.UrlReferrer.ToString());
            }

            ViewBag.AssigneeID = new SelectList(db.AspNetUsers, "Id", "Email", tasks.AssigneeID);
            ViewBag.ReporterID = new SelectList(db.AspNetUsers, "Id", "Email", tasks.ReporterID);
            ViewBag.BucketID = new SelectList(db.Buckets, "BucketID", "Title", tasks.BucketID);
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName", tasks.StatusID);
            return View(tasks);
        }

        // GET: Tasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task tasks = db.Tasks.Find(id);
            if (tasks == null)
            {
                return HttpNotFound();
            }
            ViewBag.Assignee = db.AspNetUsers;
            ViewBag.AssigneeID = new SelectList(db.AspNetUsers, "Id", "Email", tasks.AssigneeID);
            ViewBag.ReporterID = new SelectList(db.AspNetUsers, "Id", "Email", tasks.ReporterID);
            ViewBag.BucketID = new SelectList(db.Buckets, "BucketID", "Title", tasks.BucketID);
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName", tasks.StatusID);
            return View(tasks);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
     
        public ActionResult Edit([Bind(Include = "TaskID,BucketID,StatusID,AssigneeID,ReporterID,Title,Description,Startdate,Duedate")] Task tasks)
        {
            if (ModelState.IsValid)
            {
               
                db.Entry(tasks).State = EntityState.Modified;
                db.SaveChanges();
                return Redirect(Request.UrlReferrer.ToString());
            }
            ViewBag.AssigneeID = new SelectList(db.AspNetUsers, "Id", "Email", tasks.AssigneeID);
            ViewBag.ReporterID = new SelectList(db.AspNetUsers, "Id", "Email", tasks.ReporterID);
            ViewBag.BucketID = new SelectList(db.Buckets, "BucketID", "Title", tasks.BucketID);
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName", tasks.StatusID);
            return View(tasks);
        }

        // GET: Tasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task tasks = db.Tasks.Find(id);
            if (tasks == null)
            {
                return HttpNotFound();
            }
            return View(tasks);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Task tasks = db.Tasks.Find(id);
            db.Tasks.Remove(tasks);
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());
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
