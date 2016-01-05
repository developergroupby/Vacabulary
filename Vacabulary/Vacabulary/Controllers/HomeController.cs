using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vacabulary.Models;

namespace Vacabulary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult LearnBootstrap()
        {
            return View();
        }

        public ActionResult Dictionary()
        {
            return View();
        }
    }
}
