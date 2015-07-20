using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    /* Client program will call the Director, asking it to 
     * create a specific class. Director calls and/or returns 
     * the individual Builder which can be built by passing it
     * the required parameters.
     */
    class Director
    {
        public IBuilder Builder(VehicleType vehicleType)
        {
            if (vehicleType == DesignPatterns.Builder.VehicleType.Car)
                return new CarBuilder();
            else if (vehicleType == DesignPatterns.Builder.VehicleType.Bike)
                return new BikeBuilder();
            else if (vehicleType == DesignPatterns.Builder.VehicleType.Cycle)
                return new CycleBuilder();
            else return new CycleBuilder();
        }
    }
}
