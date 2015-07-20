using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class Cycle : IVehicle
    {
        public void Honk() { Console.WriteLine("Tring"); }
        public void Drive() { Console.WriteLine("Zrrrrrrr"); }
    }
}
