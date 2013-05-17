using GeometryAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometry
{
    class Cylinder : Figure, IAreaMeasurable, IVolumeMeasurable
    {
        public override double GetPrimaryMeasure()
        {
            throw new NotImplementedException();
        }

        public double GetVolume()
        {
            throw new NotImplementedException();
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
