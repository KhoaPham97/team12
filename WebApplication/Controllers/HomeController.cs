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

namespace WebApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
       

        public PartialViewResult Index()
        {
            cap21t12Entities db = new cap21t12Entities();
            ViewBag.Id = new SelectList(db.AspNetUsers, "Id", "Email");
            return PartialView();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public JsonResult GetData()
        {
            string vb = "";

            var request = (HttpWebRequest)WebRequest.Create("http://capstoneproj.azurewebsites.net/api/getDashboardInfo?code=FL6dy6LzUKXgZ0rU3n1eD6lgaXsOG0jndoVmT1Z9MWBd8YlzSYaF5Q==");
            request.Method = "GET";
            request.Headers["userid"] = User.Identity.GetUserId();
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            var response = (HttpWebResponse)request.GetResponse();
            string content = string.Empty;
            using (var stream = response.GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                    vb = content;
                }
            }
            ViewBag.Message = vb;

            return Json(vb, JsonRequestBehavior.AllowGet);
        

        }   

    }
}