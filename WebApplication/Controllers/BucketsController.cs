using System;
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
    public class BucketsController : Controller
    {
        private cap21t12Entities db = new cap21t12Entities();

        // GET: Buckets
               public ActionResult Index()
        {
            var buckets = db.Buckets.Include(b => b.Plan);
             return View(buckets.ToList());
        }
     
    

        public ActionResult Management(int? id)
        {
            var a = db.Plans.Where(x => x.IDPlan == id);
            ViewBag.B = db.Buckets.Where(x => x.PlanID == id);
            ViewBag.Message = a;
            ViewBag.b = db.Tasks.Where(x => x.BucketID == id);
            ViewBag.Task = db.Tasks;
            ViewBag.Profile = db.Profiles;
            ViewBag.Comments = db.Comments;
            ViewBag.Attachments = db.Attachments;
            ViewBag.Listmembers = db.ListMembers.Where(x => x.PlanID == id);    
            ViewBag.Assignee = db.AspNetUsers;   
            ViewBag.Status = db.Status;
            var model = db.Buckets.Where(x => x.PlanID == id);
         

        
            return View(model);


        }
        public ActionResult Test()
        {
            return View();

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
 
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title");
     
            return View();
        }

        // POST: Buckets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BucketID,PlanID,Title")] Bucket bucket)
        {
          
            if (ModelState.IsValid)
            {
                db.Buckets.Add(bucket);
                db.SaveChanges();
                return RedirectToAction("Management", "Buckets", new { id = bucket.PlanID });
            }

            ViewBag.User = new MultiSelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title", bucket.PlanID);
 
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
           
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title", bucket.PlanID);
            ViewBag.Assignee = db.AspNetUsers;
            return View(bucket);
        }

        // POST: Buckets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BucketID,PlanID,Title")] Bucket bucket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bucket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
          
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title", bucket.PlanID);
  
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
        
            var task = db.Tasks.Where(b => b.BucketID == id).AsEnumerable();        
            foreach (var bk in task)
            {
                int b = bk.TaskID;
                db.Comments.RemoveRange(db.Comments.Where(x => x.TaskID == b));
                db.Attachments.RemoveRange(db.Attachments.Where(x => x.TaskID == b));
            }
            db.Tasks.RemoveRange(db.Tasks.Where(x => x.BucketID == id));
            db.Buckets.Remove(bucket);
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
