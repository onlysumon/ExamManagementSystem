using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class ExamQuestion
    {
        public int ExamQuestionId { get; set; }        
        public int QuestionId { get; set; }
        public int ExamId { get; set; }
    }
}