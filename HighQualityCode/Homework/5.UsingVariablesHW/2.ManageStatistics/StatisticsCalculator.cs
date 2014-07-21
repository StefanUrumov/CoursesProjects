using System;
using System.Linq;
namespace _2.ManageStatistics
{
    class StatisticsCalculator
    {
        static void Main()
        {
            double[] testStatisticValuesArray = new double[] { 2.1, 4.0, 2, 1.9, 9.001, 5.3};

            CalculateStatisticData testCalculator = new CalculateStatisticData();

            testCalculator.PrintStatistics(testStatisticValuesArray, 6);
        }
    }
}
