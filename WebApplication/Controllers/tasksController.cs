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
    public class tasksController : Controller
    {
        private cap21t12Entities db = new cap21t12Entities();

        // GET: tasks
        public ActionResult Index()
        {
            var tasks = db.tasks.Include(t => t.AspNetUser).Include(t => t.Bucket).Include(t => t.Status);
            return View(tasks.ToList());
        }

        // GET: tasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            task task = db.tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        // GET: tasks/Create
        public ActionResult Create()
        {
            ViewBag.AssigneeID = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.BucketID = new SelectList(db.Buckets, "BucketID", "Title");
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName");
            return View();
        }

        // POST: tasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaskID,BucketID,StatusID,AssigneeID,Title,Description,Startdate,Duedate")] task task)
        {
            if (ModelState.IsValid)
            {
                db.tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AssigneeID = new SelectList(db.AspNetUsers, "Id", "Email", task.AssigneeID);
            ViewBag.BucketID = new SelectList(db.Buckets, "BucketID", "Title", task.BucketID);
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName", task.StatusID);
            return View(task);
        }

        // GET: tasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            task task = db.tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            ViewBag.AssigneeID = new SelectList(db.AspNetUsers, "Id", "Email", task.AssigneeID);
            ViewBag.BucketID = new SelectList(db.Buckets, "BucketID", "Title", task.BucketID);
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName", task.StatusID);
            return View(task);
        }

        // POST: tasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaskID,BucketID,StatusID,AssigneeID,Title,Description,Startdate,Duedate")] task task)
        {
            if (ModelState.IsValid)
            {
                db.Entry(task).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AssigneeID = new SelectList(db.AspNetUsers, "Id", "Email", task.AssigneeID);
            ViewBag.BucketID = new SelectList(db.Buckets, "BucketID", "Title", task.BucketID);
            ViewBag.StatusID = new SelectList(db.Status, "ID", "StatusName", task.StatusID);
            return View(task);
        }

        // GET: tasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            task task = db.tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        // POST: tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            task task = db.tasks.Find(id);
            db.tasks.Remove(task);
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
