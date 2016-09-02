using MVCDBDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCDBDemo.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDBKinEntities db = new MoviesDBKinEntities();
        // GET: Home
        public ActionResult Index(string movieGenre, string searchString)
        {
            // Creating the list box selecting by genre
            var genreList = new List<string>();

            var genreQuery = from d in db.Movies
                             orderby d.Genre
                             select d.Genre;

            // Distinct would only add the same genre once.
            genreList.AddRange(genreQuery.Distinct());
            ViewBag.movieGenre = new SelectList(genreList);

            // LINQ Query for records from DB
            var movies = from m in db.Movies
                         select m;

            // Checks to see whether the movieGenre list is empty, else add movie.
            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            // Using contains to search for substring, incase user doesnt put in full title.
            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(x => x.Title.Contains(searchString));
            }


            return View(movies);
        }

        public ActionResult Details(int? id)
        {
            Movie movie = db.Movies.Find(id);
            return View(movie);
        } 

        public ActionResult Edit(int? id)
        {
            Movie movie = db.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            // If no validation changes, do this
            if (ModelState.IsValid) {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            } // If errors stay on page
            else { return View(movie);  }
        }

        // Consider putting the http if statement code into POST and other methods
        public ActionResult Delete(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }
            Movie movie = db.Movies.Find(id);
            if (movie == null) { return HttpNotFound(); }
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult deleteConfirmed(int? id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid) {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else { return View(movie); }
        }
    }
}