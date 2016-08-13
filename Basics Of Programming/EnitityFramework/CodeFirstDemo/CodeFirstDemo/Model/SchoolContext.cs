using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Model
{
    public class SchoolContext:DbContext
    {
        public SchoolContext():base("name=CodeFirstConnectionString")
        {

        }
        public DbSet<Student> Students { set; get; }

        public DbSet<Teacher> Teachers { set; get; }

        public DbSet<SportsEvent> SportsEvents { set; get; }

        public DbSet<Address> Addresses { set; get; }
    }
}
