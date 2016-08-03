using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary.Engine
{
    public class HondaEngine:IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Honda Engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Honda Engine");
        }
    }
}
