using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns;

namespace DesignPatterns.AbstractFactory
{
    // The AbstractFactory class, contains the 
    // CreateAbstractProduct* classes
    public abstract class CarFactory
    {
        public abstract ElectricCar CreateElectricCar();
        public abstract DieselCar CreateDieselCar();
        public abstract PetrolCar CreatePetrolCar();
    }

    // AbstractProduct classes
    public abstract class ElectricCar { };
    public abstract class DieselCar { };
    public abstract class PetrolCar { };

    // ConcreteFactory classes: These create 
    // the objects.
    public class Chevrolet : CarFactory
    {
        public ElectricCar CreateElectricCar()
        {
            return new Current();
        }

        public DieselCar CreateDieselCar()
        {
            return new Cruze();
        }

        public PetrolCar CreatePetrolCar()
        {
            return new Spark();
        }
        
    }

    public class Current : ElectricCar
    {

    }

    public class Cruze : DieselCar
    {

    }

    public class Spark : PetrolCar 
    {
 
    }

    public class Honda : CarFactory
    {
        public ElectricCar CreateElectricCar()
        {
            return new Fit();
        }

        public DieselCar CreateDieselCar()
        {
            return new Amaze();
        }

        public PetrolCar CreatePetrolCar()
        {
            return new City();
        }

    }

    public class Fit : ElectricCar
    {

    }

    public class Amaze : DieselCar
    {

    }

    public class City : PetrolCar
    {

    }

}
