using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models
{
    public class Reference
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public string Image { get; set; }

        public ApplicationUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}