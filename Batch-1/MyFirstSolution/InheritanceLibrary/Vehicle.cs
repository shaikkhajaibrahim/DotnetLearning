using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary
{
    public class Vehicle
    {
        private string registrationNumber;
        private string parkingId;

        public Vehicle(string registrationNumber,string parkingId)
        {
            this.parkingId = parkingId;
            this.registrationNumber = registrationNumber;
        }

        public virtual int GetConsolidatePrice()
        {
            return 10;
        }

        public int GetPrice()
        {
            return 10;
        }

        public string GetVehicleDetails()
        {
            return $"Vehicles registration number is {registrationNumber} & parking id is {parkingId}";
        }
    }
}
