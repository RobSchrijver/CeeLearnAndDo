using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleName { get; set; }
        public string ArticleImage { get; set; }

        public ApplicationUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}