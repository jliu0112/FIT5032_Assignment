using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HungrySouls_demo1.Models
{
    public enum BookingType
    {
        PrivateDining, TableBooking
    }
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        [Required]
        [Display(Name ="Date and Time")]
        public DateTime Booking_Date_Time { get; set; }
        [Required]
        public BookingType Booking_Type { get; set; }
        [Required]
        [Range(1,10)]
        [Display(Name ="Number of People")]
        public int Booking_No_of_People { get; set; }

        
        [Display(Name ="Client")]
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }


        [Display(Name = "Staff")]
        public int StaffID { get; set; }

        public virtual Staff Staff { get; set; }
    }

}