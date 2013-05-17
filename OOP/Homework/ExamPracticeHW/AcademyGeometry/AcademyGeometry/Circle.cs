using GeometryAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometry
{
    public class Circle : Figure, IAreaMeasurable, IFlat
    {

        public override double GetPrimaryMeasure()
        {
            throw new NotImplementedException();
        }

        public Vector3D GetNormal()
        {
            throw new NotImplementedException();
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
