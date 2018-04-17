using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDescription { get; set; }
        public string CustomerEmail { get; set; }

        //public ApplicationUser AppUser { get; set; }
        //public int AppUserId { get; set; }
    }
}