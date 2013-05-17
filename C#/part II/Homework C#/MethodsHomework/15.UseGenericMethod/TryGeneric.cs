using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.UseGenericMethod
{
    class TryGeneric
    {
        static void Main()
        {                        
            decimal sum = SumElements(293939.93m, 123.253m, 891.92822m); 
            decimal product= ElementsProduct(123.65m, 9894.54m, 9383.44m);
            decimal averagee = AverageElement(74746.3m, 9282.45m, 129.54m);
            decimal max = MaxElement(8272.82m, 223.6m, 9763.21m);
            decimal min= MinElement(146.765m, 234.543m, 674.23m);

            Console.WriteLine("Sum of elements:{0} \n Product of elements{1} \n Avegare number: {2} \n Max number:{3} \n Min number {4}", sum, product, averagee, max, min);

        }                

        public static T SumElements<T>(params T[] arr)
        {
            dynamic sum = 0;
            foreach (T num in arr)
            {
                sum += num;
            }
            return sum;
        }

        public static T ElementsProduct<T>(params T[] arr)
        {
            dynamic product = 1;
            for (dynamic i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }

        public static T AverageElement<T>(params T[] arr)
        {
            dynamic sum = 0;
            for (dynamic i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / 2;
        }

        public static T MaxElement<T>(params T [] arr)
        {

            dynamic maxValue = long.MinValue;
            for (dynamic i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }

        public static T MinElement<T>(params T[] arr)
        {
            dynamic minValue = long.MaxValue;

            for (dynamic i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }

            return minValue;
        }
    }
}
