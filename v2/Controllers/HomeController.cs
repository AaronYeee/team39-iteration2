using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace v2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CSUBSIDY()
        {
            return View();
        }
        public ActionResult Differences()
        {
            return View();
        }
        public ActionResult VisualG()
        {
            return View();
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

        public ActionResult AboutKG()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult FSupport()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult HSWpage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LinKG()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EnrollmentMore()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult KinderElig()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        


    }
}