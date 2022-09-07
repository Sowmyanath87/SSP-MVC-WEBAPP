using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSP_MVC_WEBAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Wedding EVENTS and Wedding Photography";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Customer contact Details.";

            return View();
        }
    }
}