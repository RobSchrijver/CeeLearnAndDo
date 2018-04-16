using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models
{
    public class Reference
    {
        public int Id { get; set; }
        public string ReferenceTitle { get; set; }
        public string ReferenceInfo { get; set; }
        public string ReferenceImage { get; set; }

        //public ApplicationUser AppUser { get; set; }
        //public int AppUserId { get; set; }
    }
}