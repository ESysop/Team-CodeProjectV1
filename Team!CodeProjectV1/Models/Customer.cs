using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Team_CodeProjectV1.Models
{
    public class Customer
    {
    [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber  { get; set; }

        //public class CustomerDBContext : DbContext
        //{
        //   
        //}
    }
}