using System;
using System.Collections.Generic;
using System.Linq;
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
            var task = db.tasks.ToList().Where(p => p.AssigneeID == User.Identity.GetUserId());

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
    }
}