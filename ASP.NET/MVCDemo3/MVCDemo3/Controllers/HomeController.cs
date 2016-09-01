using MVCDemo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCDemo3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // GET: RSVP
        public ViewResult rsvpForm()
        {
            return View();
        }
        // POST: RSVP
        [HttpPost]
        public ViewResult rsvpForm(guestResponse response)
        {
            if (ModelState.IsValid) {
                return View("Thanks", response);
            }
            else { return View();  }

        }

    }
}