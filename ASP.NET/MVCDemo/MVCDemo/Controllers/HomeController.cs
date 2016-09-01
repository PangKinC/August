using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id = 10)
        {
            ViewBag.NumberOfTimes = id;
            return View();
        }

        public ActionResult About(string name = "", int number = 1)
        {

            ViewBag.Message = "Hello, " + name + " you typed in the number: " + number + ".";

            return View();
        }

        public ActionResult Contact(int id = 5)
        {

            ViewBag.Message = "You typed in the number: " + id;

            //ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}