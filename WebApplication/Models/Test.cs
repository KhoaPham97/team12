using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Test
    {
        public IEnumerable<Bucket> Bucket { get; set; }
        public int BucketID { get; set; }
        public int PlanID { get; set; }
        public int StatusID { get; set; }
        public string Assignee { get; set; }
        public string Reporter { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Plan Plan { get; set; }

    }
}