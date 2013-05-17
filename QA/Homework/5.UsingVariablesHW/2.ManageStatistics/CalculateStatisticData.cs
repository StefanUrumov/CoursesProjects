namespace _2.ManageStatistics
{
    using System;
    using System.Linq;

    class CalculateStatisticData
    {
        //fileds
        private double maximumValue;
        private double oldValue;
        private int statisticCount;
        private double[] statisticDataArray;


        //properties
        public double[] StatisticDataArray
        {
            get
            {
                return this.statisticDataArray;
            }
            set
            {
                this.statisticDataArray = value;
            }
        }

        public int StatisticCount
        {
            get
            {
                return this.statisticCount;
            }
            set
            {
                this.statisticCount = value;
            }
        }

        public double OldValue
        {
            get
            {
                return this.oldValue;
            }
            set
            {
                this.oldValue = value;
            }
        }

        public double MaximumValue
        {
            get
            {
                return this.maximumValue;
            }
            set
            {
                this.maximumValue = value;
            }
        }

        //methods
        /// <summary>
        /// This methods is summary and calls other methods to calculate statistic values
        /// </summary>
        /// <param name="inputDataArray">The statistic data input by the user</param>
        /// <param name="inputStatisticCount">The must be the length of the statistic data array</param>
        public void PrintStatistics(double[] inputDataArray, int inputStatisticCount)
        {
            statisticCount = inputStatisticCount;
            statisticDataArray = inputDataArray;

            PrintStatisticsMaximum();

            PrintStatisticsMinimum();

            StatisticCount = inputStatisticCount;
            PrintAverageStatisticsValue();            
        }

        /// <summary>
        /// The next methods calculates and prints maximum, minimum and avegare value in the data array
        /// </summary>
        private void PrintAverageStatisticsValue()
        {
            CalculateStatisticsAveragevalue(OldValue / StatisticCount);
            Console.WriteLine("The average statistics value is: {0}", this.OldValue);            
        }

        private double CalculateStatisticsAveragevalue(double useStatisticAverage)
        {
            OldValue = 0;
            
            for (int i = 0; i < statisticCount; i++)
            {
                OldValue += StatisticDataArray[i];
            }

            return this.OldValue;
        }

        private void PrintStatisticsMinimum()
        {            
            CalculateStatisticsMinimum(this.MaximumValue);
            Console.WriteLine("The minimum statistics value is: {0}", this.MaximumValue);
        }

        private double CalculateStatisticsMinimum(double useStatisticsMinimum)
        {
           
            for (int i = 0; i < StatisticCount; i++)
            {
                if (StatisticDataArray[i] < this.MaximumValue)
                {
                    this.MaximumValue = StatisticDataArray[i];
                }
            }

            return this.MaximumValue;
        }

        private void PrintStatisticsMaximum()
        {
            CalculateStatisticsMaximum(this.MaximumValue);
            Console.WriteLine("The maximum statistics value is: {0}", this.MaximumValue);
        }

        private double CalculateStatisticsMaximum(double useStatisticsMaximum)
        {
            for (int i = 0; i < StatisticCount; i++)
            {
                if (StatisticDataArray[i] > this.MaximumValue)
                {
                    this.MaximumValue = StatisticDataArray[i];
                }
            }

            return this.MaximumValue;
        }


    }
}
