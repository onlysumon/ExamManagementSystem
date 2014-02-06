using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool Type { get; set; }
        public int Marks { get; set; }
        public int Duration { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual IList<Option> Options { get; set; }
    }
}