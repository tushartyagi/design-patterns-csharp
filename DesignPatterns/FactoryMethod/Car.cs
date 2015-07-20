using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class Car : IVehicle
    {
        public void Honk() { Console.WriteLine("Honk"); }
        public void Drive() { Console.WriteLine("Zip"); }
    }
}
