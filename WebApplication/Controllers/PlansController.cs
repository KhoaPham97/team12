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
     

        // GET: Plans
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Test()
        {
            cap21t12Entities db = new cap21t12Entities();
            Students ob = new Students();
            ob.GetStudentsList = db.AspNetUsers.Select(s => new Students { StudentId = s.Id, StudentName = s.UserName }).ToList();
            return View(ob);
        }
        [HttpPost]
        public ActionResult Test(Students ob)
        {

            return RedirectToAction("Test");
        }

       
    
       
        public ActionResult Create()
        {

            cap21t12Entities db = new cap21t12Entities();
            Students ob = new Students();
            ob.GetStudentsList = db.AspNetUsers.Select(s => new Students { StudentId = s.Id, StudentName = s.UserName }).ToList();
            return View(ob);
        }
        [HttpPost]
        public ActionResult Create(Students ob)
        {

            return RedirectToAction("Create");
        }



    }
}
