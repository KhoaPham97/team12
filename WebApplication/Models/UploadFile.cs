using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class UploadFile
    {
        public int ID { get; set; }
        public Nullable<int> TaskID { get; set; }
        public virtual Task Task { get; set; }
        public string Attachment { get; set; }
    }
}