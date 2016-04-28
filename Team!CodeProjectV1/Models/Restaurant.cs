using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team_CodeProjectV1.Models
{
    public class Restaurant
    {
    [Key]
        public int ID { get; set; }
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        
    }
}