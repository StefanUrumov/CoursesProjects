
namespace HighQualityMethods
{
    using System;

    public class HighQMethods
    {
        public static double CalcTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0)
            {
                throw new ArgumentException("The value of first side should be positive too!");
            }

            if (secondSide <= 0)
            {
                throw new ArgumentException("The value of second side should be positive too!");
            }

            if (thirdSide <= 0)
            {
                throw new ArgumentException("The value of third side should be positive too!");
            }

            double heronParametar = (firstSide + secondSide + thirdSide) / 2;
            double triangleArea = Math.Sqrt(heronParametar * (heronParametar - firstSide) * (heronParametar - secondSide) * (heronParametar - thirdSide));
            return triangleArea;
        }

        public static string DigitName(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException("Unknown digit!");
            }
        }

        public static int FindMaxNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new NullReferenceException("The array is empty!");
            }

            int maxNumber = elements[0];
            for (int index = 1; index < elements.Length; index++)
            {
                if (elements[index] > maxNumber)
                {
                    maxNumber = elements[index];
                }
            }

            return maxNumber;
        }

        public static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Invalid format!");
            }
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static bool IsVertical(double x1, double x2, out bool isVertical)
        {
            return isVertical = x1 == x2;
        }

        public static bool IsHorizontal(double y1, double y2, out bool isHorizontal)
        {
            return isHorizontal = y1 == y2;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(DigitName(5));

            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");
            bool isVertical = false;
            bool isHorizontal = false;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine(IsVertical(3, 3, out isVertical));
            Console.WriteLine(IsHorizontal(-1, 2.5, out isHorizontal));
            Console.WriteLine("Vertical? " + isVertical);
            Console.WriteLine("Horizontal? " + isHorizontal);

            Student peter = new Student("Peter", "Ivanov", "17.03.1992", "From Sofia");
            Student stella = new Student("Stella", "Markova", "03.11.1993", "From Vidin");
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }

}
