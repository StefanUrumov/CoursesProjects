using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CustomRangeException
{
    class InvalidRangeException<T> : ApplicationException
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        //fields
        private T start;
        private T end;

        //properties
        public T Start
        {
            get { return this.start; }
            private set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            private set { this.end = value; }
        }

        //constuctors
        public InvalidRangeException(string message, T start, T end)
        {
            this.start = start;
            this.end = end;
        }

        //methods
    }
}
