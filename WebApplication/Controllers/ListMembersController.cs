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
    public class ListMembersController : Controller
    {
        private cap21t12Entities db = new cap21t12Entities();

        // GET: ListMembers
        public ActionResult Index()
        {
            var listMembers = db.ListMembers.Include(l => l.AspNetUser).Include(l => l.Plan);
            return View(listMembers.ToList());
        }

        // GET: ListMembers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListMember listMember = db.ListMembers.Find(id);
            if (listMember == null)
            {
                return HttpNotFound();
            }
            return View(listMember);
        }

        // GET: ListMembers/Create
        public ActionResult Create()
        {
            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title");
            return View();
        }

        // POST: ListMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AccountID,PlanID,RoleProject,DateJoined,DateLeft")] ListMember listMember)
        {
            if (ModelState.IsValid)
            {
                db.ListMembers.Add(listMember);
                db.SaveChanges();
                return Redirect(Request.UrlReferrer.ToString());
            }

            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email", listMember.AccountID);
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title", listMember.PlanID);
            return View(listMember);
        }

        // GET: ListMembers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListMember listMember = db.ListMembers.Find(id);
            if (listMember == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email", listMember.AccountID);
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title", listMember.PlanID);
            return View(listMember);
        }

        // POST: ListMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AccountID,PlanID,RoleProject,DateJoined,DateLeft")] ListMember listMember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listMember).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email", listMember.AccountID);
            ViewBag.PlanID = new SelectList(db.Plans, "IDPlan", "Title", listMember.PlanID);
            return View(listMember);
        }

        // GET: ListMembers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListMember listMember = db.ListMembers.Find(id);
            if (listMember == null)
            {
                return HttpNotFound();
            }
            return View(listMember);
        }

        // POST: ListMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ListMember listMember = db.ListMembers.Find(id);
            db.ListMembers.Remove(listMember);
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
