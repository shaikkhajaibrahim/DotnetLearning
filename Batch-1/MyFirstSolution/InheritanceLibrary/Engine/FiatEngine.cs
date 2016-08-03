using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary.Engine
{
    public class FiatEngine:IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Fiat Engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Fiat Engine");
        }
    }
}
