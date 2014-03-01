using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class StudentCourse
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public char Status { get; set; }

        public User User { get; set; }
    }
}