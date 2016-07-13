using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraining.NextSteps.Library.Contracts
{
    public interface IEngine
    {
        string GetEngineModel();

        int ManufacturerCode { set; get; }
    }
}
