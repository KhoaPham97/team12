using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Cmt
    {
        public int ID { get; set; }
   
        public string AccountID
        {
            get;
            set;
        }
        public int TaskID
        {
            get;
            set;
        }
        public DateTime LastUpdate
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
    }
}