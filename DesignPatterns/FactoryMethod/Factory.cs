using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Common;

namespace DesignPatterns.FactoryMethod
{
    public class Factory
    {
        public IVehicle CreateVehicle(VehicleType vehicleType)
        {
            IVehicle vehicle = null;
            switch (vehicleType)
            {
                case VehicleType.Car:
                    vehicle = new Car();
                    break;
                case VehicleType.Bike:
                    vehicle = new Bike();
                    break;
                case VehicleType.Cycle:
                    vehicle = new Cycle();
                    break;
            }
            return vehicle;
        }

    }
}
