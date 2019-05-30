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
    public class MeetingsController : Controller
    {
        private cap21t12Entities db = new cap21t12Entities();

        // GET: Meetings
        public ActionResult Index()
        {
            return Redirect(Request.UrlReferrer.ToString());
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase postedFile, int? id)
        {
            byte[] bytes = null;
            using (BinaryReader br = new BinaryReader(postedFile.InputStream))
            {
                bytes = br.ReadBytes(postedFile.ContentLength);
            }

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "INSERT INTO FileMeeting VALUES (@Name, @ContentType, @Data,@MeetingID)";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;               

                    cmd.Parameters.AddWithValue("@Name", Path.GetFileName(postedFile.FileName));
                    cmd.Parameters.AddWithValue("@ContentType", postedFile.ContentType);
                    cmd.Parameters.AddWithValue("@Data", bytes);
                    cmd.Parameters.AddWithValue("@MeetingID", Convert.ToInt32(id));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            return Redirect(Request.UrlReferrer.ToString());
        }
        [HttpPost]
        public FileResult DownloadFile(int? fileId)
        {
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT Name, Data, ContentType FROM FileMeeting WHERE ID=@Id";
                    cmd.Parameters.AddWithValue("@ID", fileId);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["Data"];
                        contentType = sdr["ContentType"].ToString();
                        fileName = sdr["Name"].ToString();
                    }
                    con.Close();
                }
            }

            return File(bytes, contentType, fileName);
        }

        private static List<Attachment> GetFiles()
        {
            List<Attachment> files = new List<Attachment>();
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Name FROM FileMeeting"))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            files.Add(new Attachment
                            {
                                ID = Convert.ToInt32(sdr["Id"]),
                                Name = sdr["Name"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return files;
        }
        public ActionResult Management(int? id)
        {
            ViewBag.Status = db.Status;
            ViewBag.Profile = db.Profiles;
            ViewBag.Meetings = db.Meetings.Where(x => x.ID == id); ;
            ViewBag.People = db.People.Where(x => x.IDMeeting == id); ;
            ViewBag.Assignee = db.AspNetUsers;
            return View();

        }
        // GET: Meetings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = db.Meetings.Find(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            return View(meeting);
        }

        // GET: Meetings/Create
        public ActionResult Create()
        {
            ViewBag.Owner = new SelectList(db.AspNetUsers, "Id", "Email");
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,StartTime,EndTime,Date,Owner,Location,Description,StatusID")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                db.Meetings.Add(meeting);
                db.SaveChanges();
                int id = meeting.ID;
                string Ow = meeting.Owner;
                using (cap21t12Entities db = new cap21t12Entities())
                {
                    Person people = new Person();
                    people.Guest = Ow;
                    people.IDMeeting = id;
                    people.Apply = true;
                    db.People.Add(people);
                    db.SaveChanges();
                }
          
             
                return RedirectToAction("Calendar","Home");
            }

            ViewBag.Owner = new SelectList(db.AspNetUsers, "Id", "Email", meeting.Owner);
            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = db.Meetings.Find(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            ViewBag.Owner = new SelectList(db.AspNetUsers, "Id", "Email", meeting.Owner);
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,StartTime,EndTime,Date,Owner,Location,Description,StatusID")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meeting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Calendar", "Home");
            }
            ViewBag.Owner = new SelectList(db.AspNetUsers, "Id", "Email", meeting.Owner);
            return View(meeting);
        }

        // GET: Meetings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = db.Meetings.Find(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Meeting meeting = db.Meetings.Find(id);
            db.People.RemoveRange(db.People.Where(x => x.IDMeeting == id));
            db.Meetings.Remove(meeting);
            db.SaveChanges();
            return RedirectToAction("Calendar", "Home");
        }
        [HttpPost]
        public ActionResult Test(HttpPostedFileBase postedFile,string  Guest,int? IDMeeting)
        {
            byte[] bytes = null;
            using (BinaryReader br = new BinaryReader(postedFile.InputStream))
            {
                bytes = br.ReadBytes(postedFile.ContentLength);
            }

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "INSERT INTO Attachments VALUES (@Guest,@IDMeeting,@Apply)";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    

                    cmd.Parameters.AddWithValue("@Guest", "30ae29b5 - e171 - 485e-818e - 86e6f7015126");
                    cmd.Parameters.AddWithValue("@IDMeeting", "2");
                    cmd.Parameters.AddWithValue("@Apply", "False");
                   
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

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
