using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HungrySouls_demo1.Models
{
    public enum Rating
    {
        Poor=1, Fair=2, Good=3, Great=4, Excellent=5
    }
    public class Review
    {

        [Key]
        public int ReviewID { get; set; }
        [Display(Name ="Client")]
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        [Required]
        [Display(Name ="Satisfication")]
        [Range(1,5)]
        public Rating RatingLevel { get; set; }
        [Required]
        [AllowHtml]
        public string Comments { get; set; }
    }
  
}