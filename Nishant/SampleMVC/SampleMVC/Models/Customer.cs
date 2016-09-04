using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleMVC.Models
{
    public class Customer
    {
        [Key]
        public int Id { set; get; }

        [Required]
        public string Name { set; get; }

        public  string MobileNumber { set; get; }
    }
}