using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public Gender? Gender { get; set; }
        public string Email { get; set; }    
        public string InstituteName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string PhotoUrl { get; set; }

        public virtual IList<Course> Courses { get; set; }
    }

    public enum Gender
    {
        M, F
    }
}