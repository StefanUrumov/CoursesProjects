
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _5.SubsetSums
{
    class CheckSum
    {
        static void Main(string[] args)
        {
            string readSum = Console.ReadLine();
            decimal S = decimal.Parse(readSum); //sum

            string readNNumbers = Console.ReadLine();
            byte N = byte.Parse(readNNumbers); //numbers

            long[] sequenceOfNumbers = new long[N];

            for (int i = 0; i < N; i++)
            {
                string readNumber = Console.ReadLine();
                long number = long.Parse(readNumber);

                sequenceOfNumbers[i] = number;
            }

            int count = 0;
            int currentSequencesLength = 0;

            decimal currentNumber = 0;
            decimal result = 0;

            for (int j = currentSequencesLength; j < sequenceOfNumbers.Length; j++)
            {
                result = sequenceOfNumbers[j];

                if (result == S)
                {
                    count++;
                }
            }

            int currentLengthOfSequences = 1;
            int nextIndex = 0;
            int length = sequenceOfNumbers.Length;

            if (length > 1)
            {
                while (true)
                {
                    for (int i = 0; i < length; i++)
                    {
                        result = 0;
                        currentNumber = 0;
                        currentSequencesLength = 0;

                        if ((currentSequencesLength < currentLengthOfSequences) &&
                            ((i + currentLengthOfSequences) < length))
                        {
                            for (int x = i; x < i + currentLengthOfSequences; x++)
                            {
                                currentNumber = currentNumber + sequenceOfNumbers[x];
                                currentSequencesLength++;
                                nextIndex = x;
                            }
                        }
                        else
                        {
                            break;
                        }

                        nextIndex++;

                        if (nextIndex < length)
                        {
                            for (int j = nextIndex; j < length; j++)
                            {
                                result = currentNumber + sequenceOfNumbers[j];

                                if (result == S)
                                {
                                    count++;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    currentLengthOfSequences++;

                    if (currentLengthOfSequences == length)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}