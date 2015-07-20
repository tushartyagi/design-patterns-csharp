using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director d = new Director();
            d.Builder(VehicleType.Car)
                .SetColor("Black")
                .SetName("Omni")
                .SetYear(2014)
                .Build();
        }
    }
}
