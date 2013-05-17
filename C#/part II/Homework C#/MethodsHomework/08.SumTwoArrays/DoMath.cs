using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumTwoArrays
{
    public class DoMath
    {
        static void Main()
        {            
            int[] fiArray = new int[] { 2, 5, 9, 8, 5, 7, 3, 6, 3, 4, 2, 8, 6, 3, 2, 7, 8 };
            int[] secArray = new int[] { 2, 8, 9, 2, 5, 7, 6, 2};

            ShowResult(fiArray, secArray);
        }

        public static void ShowResult(int[] fiArray, int[] secArray)
        {
            for (int index = 0; index < fiArray.Length; index++)
            {
                Console.Write(fiArray[index]);
            }

            Console.Write(" + ");

            for (int index = 0; index < secArray.Length; index++)
            {
                Console.Write(secArray[index]);
            }

            Console.Write(" = ");

            FindFinalSum(fiArray, secArray);
        }

        public static void FindFinalSum(int[] fiArray, int[] secArray)
        {
            int [] result = new int[Math.Max(fiArray.Length, secArray.Length)+1];

            Array.Reverse(fiArray);
            Array.Reverse(secArray);

            int add = 0;
            int calc = 0;

            for (int num = 0; num < Math.Min(fiArray.Length, secArray.Length); num++)
            {
                calc = fiArray[num] + secArray[num] + add;

                if (calc >= 10)
                {
                    add = 1;
                    result[num] = calc % 10;
                }

                if (num + 1 == Math.Min(fiArray.Length, secArray.Length))
                {
                    for (int num2 = num + 1; num2 < Math.Max(fiArray.Length, secArray.Length); num2++)
                    {
                        if (fiArray.Length > secArray.Length)
                        {
                            calc = fiArray[num2] + add;

                            if (calc >= 10)
                            {
                                add = 1;
                                result[num2] = calc % 10;
                            }
                            else
                            {
                                add = 0;
                                result[num2] = calc;
                            }
                        }
                        else
                        {
                            calc = secArray[num2] + add;

                            if (calc >= 10)
                            {
                                add = 1;
                                result[num2] = calc % 10;
                            }
                            else
                            {
                                add = 0;
                                result[num2] = calc;
                            }
                        }

                        if (num2 + 1 == Math.Max(fiArray.Length, secArray.Length) && add == 1)
                        {
                            result[num2 + 1] = add;
                        }

                    }
                }
            }

            Array.Reverse(result);

            for (int num = 0; num < result.Length; num++)
            {
                if (num == 0 && num == result[num])
                {
                    continue;
                }
                else
                {
                    Console.Write(result[num]);
                }
            }
            Console.WriteLine();
        }
    }
}
