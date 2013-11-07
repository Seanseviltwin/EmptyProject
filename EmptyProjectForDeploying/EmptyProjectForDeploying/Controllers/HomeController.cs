using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmptyProjectForDeploying.Models;

namespace EmptyProjectForDeploying.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "First push to git.";
            ViewBag.Cheeses = new[]
                {new Cheese{Name = "name1", Country = "country1"}, new Cheese{Name = "name2", Country = "country2"}};
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
