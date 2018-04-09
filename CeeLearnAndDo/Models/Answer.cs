using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerTitle { get; set; }
        public string AnswerDescription { get; set; }

        public Question Question { get; set; }
        public int QuestionId { get; set; }

        public ApplicationUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}