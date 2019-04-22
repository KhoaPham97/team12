using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication.Models;
using Newtonsoft.Json;
using System.Text;
using System.Data;

namespace WebApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        cap21t12Entities db = new cap21t12Entities();
        public PartialViewResult Index()
        {
        
            cap21t12Entities db = new cap21t12Entities();
            var product = db.Plans;

            ViewBag.Listmembers = db.ListMembers;
            ViewBag.Profile = db.Profiles;
            return PartialView(product);
        } 

        public ActionResult Calendar()
        {
            ViewBag.Meeting = db.Meetings;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}