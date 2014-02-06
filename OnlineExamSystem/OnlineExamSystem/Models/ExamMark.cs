using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class ExamMark
    {
        public int UserId { get; set; }
        public int Mark { get; set; }
        public int ExamId { get; set; }
    }
}