namespace _1.RefactorVariableNaming
{
    using System;
    using System.Linq;

    class Size
    {
        //fields
        private double width;
        private double height;

        //I use another width and height because I need them in the override ToString() method
        private double widthAfterRotation;
        private double heightAfterRotation;

        //constructors
        public Size(double inputWidth, double inputHeight)
        {
            this.width = inputWidth;
            this.height = inputHeight;
        }
        
        //properties
        public double HeightAfterRotation
        {
            get
            {
                return this.heightAfterRotation;
            }

            set
            {
                this.heightAfterRotation = value;
            }
        }

        public double WidthAfterRotation
        {
            get
            {
                return this.widthAfterRotation;
            }

            set
            {
                this.widthAfterRotation = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        //methods
        public Size GetRotatedSize(Size figureSize, double rotatedFigureAngle)
        {
            WidthAfterRotation = 
              Math.Abs(Math.Cos(rotatedFigureAngle)) * figureSize.Width +
                Math.Abs(Math.Sin(rotatedFigureAngle)) * figureSize.Height;

            HeightAfterRotation = 
              Math.Abs(Math.Sin(rotatedFigureAngle)) * figureSize.Width +
                Math.Abs(Math.Cos(rotatedFigureAngle)) * figureSize.Height;

              figureSize = new Size(WidthAfterRotation, HeightAfterRotation);

              return figureSize;
        }

        public override string ToString()
        {
            return string.Format("The size of the figure after rotation by the given angle is width: {0} and height: {1}", 
                this.WidthAfterRotation, this.HeightAfterRotation);
        }

    }
}
