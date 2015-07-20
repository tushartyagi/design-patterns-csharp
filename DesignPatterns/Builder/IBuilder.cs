using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    interface IBuilder
    {
        IBuilder SetName(string name);
        IBuilder SetYear(int year);
        IBuilder SetColor(string color);
        IBuilder Build();
    }
}
