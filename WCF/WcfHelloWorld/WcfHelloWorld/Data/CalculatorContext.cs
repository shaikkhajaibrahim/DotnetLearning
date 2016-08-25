using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfHelloWorld.Data
{
    public class CalculatorContext:DbContext
    {
        public CalculatorContext():base("name=mycon")
        {
                
        }

        public DbSet<Add> AdditionResults { set; get; }
    }
}
