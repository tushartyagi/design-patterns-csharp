using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class Bike : IVehicle
    {
        public void Honk() { Console.WriteLine("Beep"); }
        public void Drive() { Console.WriteLine("Zooooop"); }
    }
}
