using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ew774515_MIS4800.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My MIS4200 Description";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My Contact Information:";

            return View();
        }
    }
}