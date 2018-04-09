using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageLink { get; set; }

        public Article Article { get; set; }
        public int ArticleId { get; set; }

        public Reference Reference { get; set; }
        public int ReferenceId { get; set; }
    }
}