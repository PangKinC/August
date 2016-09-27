using Ratings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ratings.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs("post")]
        public ActionResult Rate(FormCollection form)
        {
            var rate = Convert.ToInt32(form["Score"]);
            var id = Convert.ToInt32(form["ArticleID"]);
            if (Request.Cookies["rating" + id] != null)
                return Content("false");
            Response.Cookies["rating" + id].Value = DateTime.Now.ToString();
            Response.Cookies["rating" + id].Expires = DateTime.Now.AddYears(1);
            ArticleRating ar = repository.IncrementArticleRating(rate, id);
            return Json(ar);
        }


    }


}