using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HungrySouls_demo1.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name = "Sender Name")]
        public string FromName { get; set; }
        public string Subject { get; set; }

        [Required, Display(Name ="Receiver Email")]
        public string ToEmail { get; set; }
        public string Bcc { get; set; }
        public string Cc { get; set; }
        [Required, Display(Name ="Contents")]
        public string Message { get; set; }
        [Display(Name ="Choose your file to upload")]
        public List<HttpPostedFileBase> Upload { get; set; }
    }
}