using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class ExamAnswer
    {
        public int ExamId { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual User User { get; set; }
        public virtual Question Question { get; set; }
        public virtual Option Option { get; set; }
    }
}