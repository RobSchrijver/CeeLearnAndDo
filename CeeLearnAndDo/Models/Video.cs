using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string VideoLink { get; set; }

        public Reference Reference { get; set; }
        public int ReferenceId { get; set; }

    }
}