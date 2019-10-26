using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HungrySouls_demo1.Models
{
    [DataContract]
    public class ReviewViewModels
    {
        [DataMember(Name = "label")]
        public string Level { get; set; }
        [DataMember(Name = "y")]
        public int Count { get; set; }
    }


}