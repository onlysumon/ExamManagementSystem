using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class Option
    {
        public int OptionId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAnswer { get; set; }
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}