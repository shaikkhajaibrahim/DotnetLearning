using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary.Engine
{
    public class ToyotaEngine:IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Toyota Engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Toyota Engine");
        }
    }
}
