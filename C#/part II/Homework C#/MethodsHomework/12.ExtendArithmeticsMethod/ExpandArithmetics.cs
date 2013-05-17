using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtendArithmeticsMethod
{
    class ExpandArithmetics
    {
        static void Main()
        {
            Console.Write("Enter degree of your 1 polynomial:");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient from smallest degree to highest:");
            int [] arr1 = new int[degree + 1];
            PutIndexInArr(arr1);

            Console.Write("Enter degree of your 2 polynomial:");
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient. from smallest degree to highest:");
            int[] arr2 = new int[degree + 1];
            PutIndexInArr(arr2);

            Console.WriteLine("Array 1");
            PrintPolynom(arr1);
            Console.WriteLine("Array 2");
            PrintPolynom(arr2);
            Console.WriteLine();

            Console.WriteLine("Subtraction of Array 1 / Array 2");
            PrintPolynom(DevideArr(arr1, arr2));
            Console.WriteLine();

            Console.WriteLine("Multiplication of of Array 1 * Array 2 ");
            PrintPolynom(MultiplyArr(arr1, arr2));
            Console.WriteLine();
        }

        static int[] PutIndexInArr(int[] arr)
        {
            int length = arr.Length;
            for (int i = length - 1; i >= 0; i--)
            {

                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }
            return arr;
        }

        static int[] SubstractArrays(int[] arr1, int[] arr2)
        {
            int LengthArr1 = arr1.Length;
            int LengthArr2 = arr2.Length;

            int biggerLength = arr1.Length;
            int smallerLength = arr2.Length;

            if (arr2.Length > arr1.Length)
            {
                biggerLength = arr2.Length;
                smallerLength = arr1.Length;
            }

            int[] sumArr = new int[biggerLength];

            for (int i = 0; i < biggerLength; i++)
            {
                if (i > smallerLength - 1)
                {
                    sumArr[i] = LengthArr1 > LengthArr2 ? arr1[i] : arr2[i];
                }
                else
                {
                    sumArr[i] = arr1[i] - arr2[i];
                }

            }
            return sumArr;
        }

        static int[] MultiplyArr(int[] arr1, int[] arr2)
        {
            int LengthArr1 = arr1.Length;
            int LengthArr2 = arr2.Length;

            int biggerLength = arr1.Length;
            int smallerLength = arr2.Length;

            if (arr2.Length > arr1.Length)
            {
                biggerLength = arr2.Length;
                smallerLength = arr1.Length;
            }

            int[] multiArr = new int[biggerLength];

            for (int i = 0; i < biggerLength; i++)
            {
                if (i > smallerLength - 1)
                {
                    multiArr[i] = LengthArr1 > LengthArr2 ? arr1[i] : arr2[i];
                }
                else
                {
                    multiArr[i] = arr1[i] * arr2[i];
                }

            }
            return multiArr;
        }

        static int[] DevideArr(int[] arr1, int[] arr2)
        {
            int LengthArr1 = arr1.Length;
            int LengthArr2 = arr2.Length;

            int biggerLength = arr1.Length;
            int smallerLength = arr2.Length;

            if (arr2.Length > arr1.Length)
            {
                biggerLength = arr2.Length;
                smallerLength = arr1.Length;
            }

            int[] devideArr = new int[biggerLength];

            for (int i = 0; i < biggerLength; i++)
            {
                if (i > smallerLength - 1)
                {
                    devideArr[i] = LengthArr1 > LengthArr2 ? arr1[i] : arr2[i];
                }
                else
                {
                    if (arr2[i] != 0)
                    {
                        devideArr[i] = arr1[i] / arr2[i];
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        Console.WriteLine("One of coefficients is ZERO and you are trying to divide to it");
                        Array.Clear(devideArr, 0, devideArr.Length);
                        break;
                    }

                }

            }
            return devideArr;
        }

        static string ReturnPositiveSign(int[] arr, int i)
        {
            if (arr[i] > 0)
            {
                string signPlus = "+";
                return signPlus;
            }
            else
            {
                return string.Empty;
            }
        }

        static void PrintPolynom(int[] arr)
        {
            int length = arr.Length - 1;
            for (int i = 0; i <= length; i++)
            {
                if (arr[i] != 0)
                {
                    if (i != arr.Length - 1 && i != arr.Length - 2)
                    {
                        Console.Write("{2}{0:F2}x^{1}", arr[i], length - i, ReturnPositiveSign(arr, i));
                    }
                    else if (i == arr.Length - 2)
                    {
                        Console.Write("{1}{0:F2}x", arr[i], ReturnPositiveSign(arr, i));

                    }
                    else if (i == arr.Length - 1)
                    {
                        Console.Write("{1}{0:F2}", arr[i], ReturnPositiveSign(arr, i));
                    }
                }
            }
            Console.WriteLine();
        }

    }
}
