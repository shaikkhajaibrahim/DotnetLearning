using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleMVC.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext():base("name=CustomerConnectionString")
        {
                
        }

        public DbSet<Customer> Customers { set; get; }
    }
}