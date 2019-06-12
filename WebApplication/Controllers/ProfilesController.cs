using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ProfilesController : Controller
    {
        private cap21t12Entities db = new cap21t12Entities();

        // GET: Profiles
        public ActionResult Index()
        {
            var profiles = db.Profiles.Include(p => p.AspNetUser);
            return View(profiles.ToList());
        }

        // GET: Profiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }
   
        public ActionResult Create()
        {
            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email");
            return View();
        }

        // POST: Profiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        public int FileSize { get; set; } = 1 * 1024 * 1024 * 1024;
        public string Extensions { get; set; } = "png,jpg,jpeg,gif";
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccountID,Full_Name,Birthday,PhoneNumber,Address,Avatar")] Profile profile, HttpPostedFileBase file)
        {
            bool isValid = true;
            List<string> allowedExtensions = this.Extensions.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            // Settings.
            int allowedFileSize = this.FileSize;
            if (ModelState.IsValid)
            {
           
             
                if (file != null)
                {
                    var fileSize = file.ContentLength;
                    var fileName = file.FileName;

                    // Settings.
                    isValid = allowedExtensions.Any(y => fileName.EndsWith(y)) && fileSize <= allowedFileSize;

                    if (isValid == true)
                    {
                        file.SaveAs(HttpContext.Server.MapPath("~/Content/Images/")
                                                                  + file.FileName);
                        profile.Avatar = file.FileName;
                     
                    }
                 
                }
                db.Profiles.Add(profile);
                db.SaveChanges();
                return Redirect(Request.UrlReferrer.ToString());

            }

            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email", profile.AccountID);
            return View(profile);
        }

        // GET: Profiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email", profile.AccountID);
            return View(profile);
        }

        // POST: Profiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccountID,Full_Name,Birthday,PhoneNumber,Address,Avatar")] Profile profile, HttpPostedFileBase file)
        {
            bool isValid = true;
            List<string> allowedExtensions = this.Extensions.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            // Settings.
            int allowedFileSize = this.FileSize;
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var fileSize = file.ContentLength;
                    var fileName = file.FileName;

                    // Settings.
                    isValid = allowedExtensions.Any(y => fileName.EndsWith(y)) && fileSize <= allowedFileSize;

                    if (isValid == true) { 
                        file.SaveAs(HttpContext.Server.MapPath("~/Content/")
                                                                  + file.FileName);
                    profile.Avatar = file.FileName;
                }
             
                }
                db.Entry(profile).State = EntityState.Modified;
                db.SaveChanges();
                return Redirect(Request.UrlReferrer.ToString());
            }
            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email", profile.AccountID);
            return Redirect(Request.UrlReferrer.ToString());
        }
        
        // GET: Profiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        // POST: Profiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profile profile = db.Profiles.Find(id);
            db.Profiles.Remove(profile);
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
