using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct |
                    AttributeTargets.Class |
                    AttributeTargets.Interface |
                    AttributeTargets.Method |
                    AttributeTargets.Enum)]

    class GetVersion : System.Attribute
    {
        private int minorVer;
        private int majorVer;

        public int MinorVer
        {
            get { return this.minorVer; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Minor version has to be positive number." + value);
                }
                this.minorVer = value; }
        }

        public int MajorVer
        {
            get { return this.majorVer; }
            private set {
                if (value < 0)
                {
                    throw new ArgumentException("Major version has to be positive number." + value);
                }
                this.majorVer = value; }
        }

        public GetVersion(int majorVer, int minorVer)
        {
            this.MinorVer = minorVer;
            this.MajorVer = majorVer;
        }

        public override string ToString()
        {
            return String.Format("{0}.{1}", MajorVer, MinorVer);
        }
    }
}
