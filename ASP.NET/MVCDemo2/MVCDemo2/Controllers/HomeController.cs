using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo2.Models;

namespace MVCDemo2.Controllers
{
    public class HomeController : Controller
    {
        List<Album> albums = new List<Album>();

        // GET: Home
        public ActionResult Index()
        {
            Album alb1 = new Album("Dark Side of the Moon", "Pink Floyed", "Vinyl", 9.99M);
            Album alb2 = new Album("Tubular Bells", "Mike Oldfield", "Vinyl", 8.99M);
            Album alb3 = new Album("Alright, Still", "Lily ALlen", "CD", 13.99M);

            albums.Add(alb1);
            albums.Add(alb2);
            albums.Add(alb3);
            
            return View(albums);
        }
    }
}