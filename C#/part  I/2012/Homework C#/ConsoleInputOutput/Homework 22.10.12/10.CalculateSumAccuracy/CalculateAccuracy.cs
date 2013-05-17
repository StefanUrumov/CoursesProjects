using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CalculateSumAccuracy
{
    class CalculateAccuracy
    {
        static void Main()
        {
            double firstNum = 3d;
            double secondNum = 2d;
            double sumFirst = 0.0d, sumSecond = 0.0d;
            double sum;
            for (int index = 0; index < 5000; index++)
            {
                sumSecond = sumSecond + (1d / firstNum);
                firstNum = firstNum + 2d;
                sumFirst = sumFirst + (1d / secondNum);
                secondNum = secondNum + 2d;
            }
            sum = 1.0d + sumFirst - sumSecond;

            Console.WriteLine("The sum of the numbers with required accuracy is: {0:F3}", sum);
        }
    }
}
