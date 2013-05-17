using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;


namespace _1.MathExpression
{
    class DoMath
    {
        static void Main()
        {

            // avoids problems with floating point
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            
            decimal N = decimal.Parse(Console.ReadLine());
            decimal M = decimal.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());

            if (N != 0 && M != 0 && P != 0)
            {
                //brackets can affect the floating point result 
                decimal result = (N * N + (1 / (M * P)) + 1337) / (N - 128.523123123m * P) + (decimal)Math.Sin((int)M % 180);
                Console.WriteLine("{0:0.000000}", result);
            }
            else
            {
                Console.WriteLine("Inccorect input!");
            }
        }
    }
}
