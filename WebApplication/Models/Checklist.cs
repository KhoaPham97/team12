//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Checklist
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int TaskID { get; set; }
        public int AttachmentsID { get; set; }
    
        public virtual Attachment Attachment { get; set; }
        public virtual Task Task { get; set; }
    }
}