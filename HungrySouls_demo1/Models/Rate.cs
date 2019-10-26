using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HungrySouls_demo1.Models
{
    public class Rate
    {
        [Key]
        public int RatingId { get; set; }
        public int StaffID { get; set; }
        public virtual Staff Staff { get; set; }
        [Range(0, 9)]
        [Display(Name = "Rank")]
        public decimal Rank { get; set; }
    }
}