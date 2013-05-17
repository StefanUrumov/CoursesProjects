using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Genome_Decoder
{
    class GenomeDecoder
    {
        static int n;
        static int m;
        static string inputString;
        static string inputS;
        static string[] input;
        static string allString;
        static int allLines;
        static int i;
        static int j;
        static int k;

        static void Main(string[] args)
        {
            inputString = Console.ReadLine();
            char split = ' ';
            input = inputString.Split(split);
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);
            inputS = Console.ReadLine();
            char[] delimiter = { 'A', 'T', 'G', 'C' };
            string[] number = inputS.Split(delimiter);
            int[] numbers = new int[number.Length - 1];
            numbers = Splitter(number, numbers);

            string builded = Recognize(inputS, numbers);
            allLines = 0;
            if (builded.Length % n == 0)
            {
                allLines = (builded.Length / n);
            }
            else
            {
                allLines = (builded.Length / n) + 1;
            }
            allString = allLines.ToString();
            allLines = allString.Length;
            RecursionM(builded, 0, 1);
        }

        static void RecursionM(string build, int counter, int line)
        {
            if (counter < build.Length)
            {
                Console.Write(line.ToString().PadLeft(allLines) + " ");
                for (j = 0; j < n; j = j)
                {
                    for (k = 0; k < m; k++)
                    {
                        FirstLoop(build, counter);
                        counter++;
                        j++;
                    }
                    if (counter == build.Length + 1 || j >= n)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    int nj = n - j;
                    if (nj < m)
                    {
                        for (i = 0; i < nj; i++)
                        {
                            SecondLoop(build, counter);
                            counter++;
                            j++;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                line++;
                Console.WriteLine();
                RecursionM(build, counter, line);
            }
        }
        static void FirstLoop(string build, int counter)
        {
            try
            {
                Console.Write(build[counter]);
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }
        static void SecondLoop(string build, int counter)
        {
            try
            {
                Console.Write(build[counter]);
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }
        static int[] Splitter(string[] number, int[] numbers)
        {
            for (i = 0; i < number.Length; i++)
            {
                if (number[i] == "")
                {
                    number[i] = "1";
                }
            }
            for (i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Int32.Parse(number[i]);
            }
            return numbers;
        }
        static string Recognize(string inputString, int[] numbers)
        {
            int counter = 0;
            StringBuilder builder = new StringBuilder();
            for (i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'A' || inputString[i] == 'T' || inputString[i] == 'G' || inputString[i] == 'C')
                {
                    for (j = 0; j < numbers[counter]; j++)
                    {
                        builder.Append(inputString[i]);
                    }
                    counter++;
                }
            }
            return builder.ToString();
        }
    }
}
