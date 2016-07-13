using DotnetTraining.NextSteps.Library.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraining.NextSteps.Library.Implementations
{
    public class VVTT:IEngine
    {
        public int ManufacturerCode
        {
            get; set;
        }

        public string GetEngineModel()
        {
            return "Fiat Engine 2016";
        }
    }
}
