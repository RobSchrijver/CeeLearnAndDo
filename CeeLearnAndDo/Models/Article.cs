using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace CeeLearnAndDo.Models
{

    public class Article
    {
        public int Id { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleName { get; set; }
        public string ArticlePhoto { get; set; }
        public string ArticleVideo { get; set; }

        [AllowHtml]
        public string ArticleText { get; set; }

        public bool ArticleAccepted { get; set; }
        
        //public ApplicationUser AppUser { get; set; }
        //public int AppUserId { get; set; }

    }

    public class ArticleDBContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}