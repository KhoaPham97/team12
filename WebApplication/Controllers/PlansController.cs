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
    public class PlansController : Controller
    {
        private cap21t12Entities db = new cap21t12Entities();

        // GET: Plans
        public ActionResult Index()
        {
            var plans = db.Plans.Include(p => p.Title);
            return View(plans.ToList());
        }

        // GET: Plans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = db.Plans.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // GET: Plans/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Plans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDPlan,Title,AccountID")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                db.Plans.Add(plan);                
                db.SaveChanges();
                int id = plan.IDPlan;
                string Ow = plan.AccountID;
                using (cap21t12Entities db = new cap21t12Entities())
                {
                    ListMember people = new ListMember();
                    people.AccountID = Ow;
                    people.PlanID = id;
                    people.RoleProject = false;
                    people.DateJoined = DateTime.Now;               
                    db.ListMembers.Add(people);
                    db.SaveChanges();
                }
                return RedirectToAction("Management", "Buckets", new { id = plan.IDPlan });
            }
            return View(plan);
        }

        // GET: Plans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = db.Plans.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }

            return View(plan);
        }

        // POST: Plans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDPlan,Title")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        
            return View(plan);
        }

        // GET: Plans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = db.Plans.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // POST: Plans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Plan plan = db.Plans.Find(id);
            var bucket = db.Buckets.Where(b => b.PlanID == id).AsEnumerable();
      
            foreach (var bk in bucket)
            {
                int bb = bk.BucketID;
                var tasks = db.Tasks.Where(b => b.BucketID == bb).AsEnumerable();
                foreach (var bkk in tasks)
                {
                    int c = bkk.TaskID;
                    db.Comments.RemoveRange(db.Comments.Where(x => x.TaskID == c));
                    db.Attachments.RemoveRange(db.Attachments.Where(x => x.TaskID == c));
                
                }
                db.Tasks.RemoveRange(db.Tasks.Where(x => x.BucketID == bb));
            }


            db.Buckets.RemoveRange(db.Buckets.Where(x => x.PlanID == id));
            db.ListMembers.RemoveRange(db.ListMembers.Where(x => x.PlanID == id));
            db.Plans.Remove(plan);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
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
