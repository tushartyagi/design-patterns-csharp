using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class CarBuilder : IBuilder
    {
        int Wheels;
        string Color;
        int Year;
        string Name;

        public CarBuilder()
        {
            this.Wheels = 4;
        }

        public IBuilder SetName(string name)
        {
            this.Name = name;
            return this;
        }

        public IBuilder SetYear(int year)
        {
            this.Year = year;
            return this;
        }

        public IBuilder SetColor(string color)
        {
            this.Color = color;
            return this;
        }

        public IBuilder Build()
        {
            return this;
        }
    }
}
