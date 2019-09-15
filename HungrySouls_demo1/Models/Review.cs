using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HungrySouls_demo1.Models
{
    public enum Rating
    {
        Poor, Fair, Good, Great, Excellent
    }
    public class Review
    {

        [Key]
        public int ReviewID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        [Required]
        [Display(Name ="Satisfication")]
        public Rating RatingLevel { get; set; }
        public string Comments { get; set; }
    }
}