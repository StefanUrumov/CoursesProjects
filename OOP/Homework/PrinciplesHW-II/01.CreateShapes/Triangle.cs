using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateShapes
{
    class Triangle : Shape
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
            set { this.height = value; }
        }

        public override double CalculateSurface()
        {
            double area = (height * width) / 2;
            return area;
        }

        //public Triangle()
        //{
        //
        //}

        public Triangle(double width, double height)            
        {
            this.width = width;
            this.height = height;
        }

    }
}
