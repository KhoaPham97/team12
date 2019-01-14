using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication.Models;
namespace WebApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        cap21t12Entities db = new cap21t12Entities();
        public PartialViewResult Index()
        {
            var task = db.Tasks.ToList().Where(p => p.ReporterID == User.Identity.GetUserId());

            return PartialView(task);
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
            
            var request = (HttpWebRequest)WebRequest.Create("http://team12capstone.azurewebsites.net/api/getDashboardInfo?code=fbwsp20FQUSn65sqULGVOdX/4ETTXjqyAdIeADMzep9ZZdJjiOMs/Q==");
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