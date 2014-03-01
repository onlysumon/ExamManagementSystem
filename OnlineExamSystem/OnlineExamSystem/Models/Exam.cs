using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal TotalMarks { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual IList<ExamQuestion> ExamQuestions { get; set; }
        public virtual IList<ExamAnswer> ExamAnswers { get; set; }
        public virtual IList<ExamMark> ExamMarks { get; set; }
    }
}