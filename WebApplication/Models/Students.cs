using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Students
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public List<Students> GetStudentsList { get; set; }
    }
}