using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Common;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            IVehicle car = factory.CreateVehicle(VehicleType.Car);
            IVehicle bike = factory.CreateVehicle(VehicleType.Bike);
            IVehicle cycle = factory.CreateVehicle(VehicleType.Cycle);
        }
    }
}
