using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleApplication2.Models
{
    public class UsContext:DbContext
    {
        public DbSet<Customer> Customers { set; get; }
    }
}