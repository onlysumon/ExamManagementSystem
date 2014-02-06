using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Describtion { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual IList<Question> Questions { get; set; }
    }
}