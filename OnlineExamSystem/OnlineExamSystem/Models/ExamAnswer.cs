using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class ExamAnswer
    {
        public int ExamAnswerId { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }
        public int ExamId { get; set; }
    }
}