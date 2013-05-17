using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateShapes
{
    class Circle :Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return this.Width = width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.Height = height; }            
            set {
                if (this.Height != this.Width)
                {                    
                    throw new ArgumentException( "When circle - with and heght must be equal!");                    
                }
                this.height = this.width;
            }
        }

        public override double CalculateSurface()
        {
            double area = Math.PI * ( width * width);
            return area;
        }
                
        public Circle(double width)            
        {
            this.width = width;            
        }

    }
}
