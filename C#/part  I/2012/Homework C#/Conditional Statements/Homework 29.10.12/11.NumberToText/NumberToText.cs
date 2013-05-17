using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumberToText
{
    class NumberToText
    {
        static bool isValid;
        static string userInput;
        static int numberValue;

        static void Main()
        {   
            do
            {
                Console.Write("Enter a number [0...999]:");
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out numberValue);
                if (!isValid)
                {
                    Console.WriteLine("Incorrect input!");
                }
            } while (!isValid);

            ConvertNumberToWords();
                   
        }

        static void ConvertNumberToWords()
        {
            string output = "";
            byte numberLength = 0;
            byte hundreds, tens, ones;
            hundreds = (byte)(numberValue / 100);
            tens = (byte)(numberValue % 100 / 10);
            ones = (byte)(numberValue % 10);
 
            if (numberValue < 10)
            {
                numberLength = 1;
            }
            else if (numberValue < 100)
            {
                numberLength = 2;
            }
            else if (numberValue < 1000)
            {
                numberLength = 3;
            }
            else
            {
                Console.WriteLine("The program is working only with numbers between 0 and 999!");
                return;
            }
           
            if (numberValue != 0)
            {
                for (int i = numberLength; i >= 1; i--)
                {
                    if (i == 3 || (i == 1 && tens != 1 && ones != 0))
                    {
                        switch (i == 3 ? hundreds : ones)
                        {
                            case 1:
                                output += "one";
                                break;
                            case 2:
                                output += "two";
                                break;
                            case 3:
                                output += "three";
                                break;
                            case 4:
                                output += "four";
                                break;
                            case 5:
                                output += "five";
                                break;
                            case 6:
                                output += "six";
                                break;
                            case 7:
                                output += "seven";
                                break;
                            case 8:
                                output += "eight";
                                break;
                            case 9:
                                output += "nine";
                                break;
                            default:
                                Console.WriteLine("An error has been found in hundreds or ones!");
                                break;
                        }
                        output += i == 3 ? " hundred " : "";
                        output += (i == 3 && tens < 2 && (tens != 0 || ones != 0)) ? "and " : "";
                    }
                    else
                    {
                        if (tens == 1)
                        {
                            switch (ones)
                            {
                                case 0:
                                    output += "ten";
                                    break;
                                case 1:
                                    output += "eleven";
                                    break;
                                case 2:
                                    output += "twelve";
                                    break;
                                case 3:
                                    output += "thirteen";
                                    break;
                                case 4:
                                    output += "fourteen";
                                    break;
                                case 5:
                                    output += "fifteen";
                                    break;
                                case 6:
                                    output += "sixteen";
                                    break;
                                case 7:
                                    output += "seventeen";
                                    break;
                                case 8:
                                    output += "eighteen";
                                    break;
                                case 9:
                                    output += "nineteen";
                                    break;
                                default:
                                    Console.WriteLine("An error has been found in tens!");
                                    break;
                            }
                            break;
                        }
                        else if (tens != 0)
                        {
                            switch (tens)
                            {
                                case 2:
                                    output += "twenty ";
                                    break;
                                case 3:
                                    output += "thirty ";
                                    break;
                                case 4:
                                    output += "fourty ";
                                    break;
                                case 5:
                                    output += "fifty ";
                                    break;
                                case 6:
                                    output += "sixty ";
                                    break;
                                case 7:
                                    output += "seventy ";
                                    break;
                                case 8:
                                    output += "eighty ";
                                    break;
                                case 9:
                                    output += "ninety ";
                                    break;
                                default:
                                    Console.WriteLine("An error has been found in tens!");
                                    break;
                            }
                            if (ones == 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                output = "zero";
            }
 
            output = output.First().ToString() + String.Join("", output.Skip(1));
            Console.WriteLine("Text corresponding in English pronunciation - {0}", output); 
        }
    }
}
