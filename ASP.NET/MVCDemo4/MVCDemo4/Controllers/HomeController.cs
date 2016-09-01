using MVCDemo4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo4.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDBKinEntities db = new MoviesDBKinEntities(); 

        // GET: Home
        public ActionResult Index()
        {

            // Link Query
            var movies = from m in db.Movies
                         select m;
            return View(movies);


        }
    }
}