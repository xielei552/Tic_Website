using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tic_Website.Controllers
{
  [RequireHttps]
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is China.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Trips()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [Authorize]
        public ActionResult Pick_up()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }


        public ActionResult Tips()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here are our contact information.";

            return View();
        }
        public ActionResult PorcessRequest()
        {
            ViewBag.Message = "Here are our contact information.";

            return View();
        }
    }
}
