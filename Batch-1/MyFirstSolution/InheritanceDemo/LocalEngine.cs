using InheritanceLibrary.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class LocalEngine:IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Local Engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Local Engine");
        }
    }
}
