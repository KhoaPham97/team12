using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication.Controllers
{
    public class CommentsController : Controller
    {
        private cap21t12Entities db = new cap21t12Entities();

        // GET: Comments
        public ActionResult Index()
        {
            var comments = db.Comments.Include(c => c.AspNetUser).Include(c => c.Task);
            return View(comments.ToList());
        }

        // GET: Comments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // GET: Comments/Create
        public ActionResult Create()
        {
            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.TaskID = new SelectList(db.Tasks, "TaskID", "AssigneeID");
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AccountID,TaskID,LastUpdate,Name")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Comments.Add(comment);
                db.SaveChanges();
                return Redirect(Request.UrlReferrer.ToString());
            }

            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email", comment.AccountID);
            ViewBag.TaskID = new SelectList(db.Tasks, "TaskID", "AssigneeID", comment.TaskID);
            return View(comment);
        }
        [HttpPost]
        public ActionResult AjaxPostCall(string AccountID, int TaskID, DateTime LastUpdate, string Name)
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "INSERT INTO Comments VALUES (@AccountID,@TaskID,@LastUpdate,@Name)";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;                  

                    cmd.Parameters.AddWithValue("@AccountID", AccountID);
                    cmd.Parameters.AddWithValue("@TaskID", TaskID);
                    cmd.Parameters.AddWithValue("@LastUpdate", LastUpdate);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            ViewBag.Records = "AccountID : " + AccountID + " TaskID:  " + TaskID + " LastUpdate: " + LastUpdate + " Name: " + Name;
            return Redirect(Request.UrlReferrer.ToString());
        }


        // GET: Comments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email", comment.AccountID);
            ViewBag.TaskID = new SelectList(db.Tasks, "TaskID", "AssigneeID", comment.TaskID);
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AccountID,TaskID,LastUpdate,Name")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccountID = new SelectList(db.AspNetUsers, "Id", "Email", comment.AccountID);
            ViewBag.TaskID = new SelectList(db.Tasks, "TaskID", "AssigneeID", comment.TaskID);
            return View(comment);
        }

        // GET: Comments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comment comment = db.Comments.Find(id);
            db.Comments.Remove(comment);
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
