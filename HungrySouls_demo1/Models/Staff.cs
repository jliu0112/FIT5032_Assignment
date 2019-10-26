using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HungrySouls_demo1.Models
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }
        public string Staff_FirstName { get; set; }

        [Required]
        public string Staff_LastName { get; set; }
        [Required]
        public string Staff_Email { get; set; }
        [Required]
        public string Staff_Phone { get; set; }
        public string Staff_Address { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Rate> Rates { get; set; } = new HashSet<Rate>();
        [NotMapped]
        public decimal OverallRating { get
            {
                if (Rates.Count > 0)
                {
                    return (Rates.Average(x => x.Rank));
                }
                return (9);
            } }
    }
}