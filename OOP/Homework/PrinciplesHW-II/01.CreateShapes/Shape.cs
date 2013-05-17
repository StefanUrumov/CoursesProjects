using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateShapes
{
    public abstract class Shape
    {
        double width { get; set; }
        double height { get; set; }

       public abstract double CalculateSurface();
    }
}
