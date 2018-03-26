using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models
{
    public class Reaction
    {
        public int Id { get; set; }
        public string ReactionTitle { get; set; }
        public string ReactionDescription { get; set; }

        public Article Article { get; set; }
        public int ArticleId { get; set; }
    }
}