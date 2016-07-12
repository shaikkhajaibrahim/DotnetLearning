using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraining.NextSteps.Library
{
    public class Car:Vehicle
    {
        public Car(string engineType):base(engineType)
        {

        }
        public void DisplayInfo()
        {
            Console.WriteLine("Wheel Count is "+WheelCount);
            Console.WriteLine("Engine is "+engineType);
        }

        public void Commute()
        {
            Console.WriteLine("Commuting in Car");
        }

        public override void AdvancedCommute()
        {
            Console.WriteLine("Adv Commuting in Car");
        }
    }
}
