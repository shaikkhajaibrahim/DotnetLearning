using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ModelNViewDemo.Models
{
    public class MobileStoreContext:DbContext
    {
        public MobileStoreContext():base("name=CodeFirstConnectionString")
        {

        }

        public DbSet<Customer> Customers { set; get; }

        public DbSet<Phone> Phones { set; get; }
    }
}