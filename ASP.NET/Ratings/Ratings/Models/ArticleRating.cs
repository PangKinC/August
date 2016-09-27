using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ratings.Models
{
    public class ArticleRating : Rating
    {
        public int ArticleID { get; set; }
        public int Rating { get; set; }
        public int TotalRaters { get; set; }
        public double AverageRating { get; set; }

        public string Check(double lower, double upper, double toCheck)
        {
            return toCheck > lower && toCheck <= upper ? " checked=\"checked\"" : null;
        }

        public ArticleRating IncrementArticleRating(int rate, int id)
        {
            var article = de.ArticleSet
                      .Where(a => a.ArticleID == id)
                      .First();
            article.Rating += rate;
            article.TotalRaters += 1;
            de.SaveChanges();
            var ar = new ArticleRating()
            {
                ArticleID = this.ArticleID,
                Rating =.Rating,
                TotalRaters = article.TotalRaters,
                AverageRating = Convert.ToDouble(article.Rating) / Convert.ToDouble(article.TotalRaters)
            };
            return ar;
        }
    }




}