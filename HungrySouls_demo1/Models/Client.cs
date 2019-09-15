using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HungrySouls_demo1.Models
{
    public class Client
    {

        [Key]
        public int ClientID { get; set; }
        [Required]
        public string Client_FirstName { get; set; }

        [Required]
        public string Client_LastName { get; set; }
        public DateTime Client_DOB { get; set; }

        [Required]
        public string Client_Email { get; set; }
        public string Client_Phone { get; set; }
        public string Client_Address { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}