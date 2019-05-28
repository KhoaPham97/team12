using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using System.IO;

using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication.Controllers
{
    public class PeopleController : Controller
    {
        private cap21t12Entities db = new cap21t12Entities();

        // GET: People
        public ActionResult Index()
        {
            var people = db.People.Include(p => p.AspNetUser).Include(p => p.Meeting);
            return View(people.ToList());
        }

        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            ViewBag.Guest = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.IDMeeting = new SelectList(db.Meetings, "ID", "Title");
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Guest,IDMeeting,Apply")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();
                return RedirectToAction("Calendar", "Home");
            }

            ViewBag.Guest = new SelectList(db.AspNetUsers, "Id", "Email", person.Guest);
            ViewBag.IDMeeting = new SelectList(db.Meetings, "ID", "Title", person.IDMeeting);
            return View(person);
        }

        // GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            ViewBag.Guest = new SelectList(db.AspNetUsers, "Id", "Email", person.Guest);
            ViewBag.IDMeeting = new SelectList(db.Meetings, "ID", "Title", person.IDMeeting);
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Guest,IDMeeting,Apply")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Calendar", "Home");
            }
            ViewBag.Guest = new SelectList(db.AspNetUsers, "Id", "Email", person.Guest);
            ViewBag.IDMeeting = new SelectList(db.Meetings, "ID", "Title", person.IDMeeting);
            return View(person);
        }
        public JsonResult beforeCheckPeople(int? idMeeting)
        {
            var allPeople = db.People.Where(x => x.IDMeeting == idMeeting).ToList();
            // save tất cả cột apply của allpeople thành false tại đây
            //code here
            foreach (var people in allPeople)
            {
                people.Apply = false;
                db.Entry(people).State = EntityState.Modified;
            }
            db.SaveChanges();
            return Json(new
            {
                status_code = 202,
                status_message = "All false",

            }, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getPeopleById(int id)
        {
            var a = db.People.Where(x => x.IDMeeting == id);
            var people = a.OrderByDescending(o => o.ID).FirstOrDefault();
            return Json(new
            {
                ID = people.ID,
                GuestID = people.Guest,
                MeetingID = people.IDMeeting,
                Apply = people.Apply,
         
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Test(HttpPostedFileBase postedFile, int? id)
        {
            byte[] bytes = null;
            using (BinaryReader br = new BinaryReader(postedFile.InputStream))
            {
                bytes = br.ReadBytes(postedFile.ContentLength);
            }

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "UPDATE INTO People VALUES (@Guest,@IDMeeting,@Apply)";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@CommentID", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Reporter", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Date", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ChecklistID", DBNull.Value);

                    cmd.Parameters.AddWithValue("@Name", Path.GetFileName(postedFile.FileName));
                    cmd.Parameters.AddWithValue("@ContentType", postedFile.ContentType);
                    cmd.Parameters.AddWithValue("@Data", bytes);
                    cmd.Parameters.AddWithValue("@TaskID", Convert.ToInt32(id));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            return Redirect(Request.UrlReferrer.ToString());
        }

        // GET: People/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = db.People.Find(id);
            db.People.Remove(person);
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
