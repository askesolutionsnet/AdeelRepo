using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMobileApp.Controllers
{
    public class HomeController : Controller
    {

        public int MyProperty { get; set; }

        public HomeController()
        {

        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page Adeel Khan";

            return View();
        }
    }
}
