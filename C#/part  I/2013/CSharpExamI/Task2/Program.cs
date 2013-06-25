using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());
            string line = string.Empty;
            string lineTrim = string.Empty;
            string currentLine = string.Empty;            
            int mitko = 0;
            int vlado = 0;
            
            for (int i = 0; i < rounds; i++)
            {
                line = Console.ReadLine();
                lineTrim = line.TrimStart('0');
                for (int k = 0; k < lineTrim.Length; k++)
                {
                    if (Char.IsDigit(lineTrim[k]))
                    {
                      currentLine += lineTrim[k];
                    }
                }



                if (currentLine.Length % 2 == 0)
                {
                    for (int b = 0; b < currentLine.Length; b++)
                    {
                        if (b < currentLine.Length / 2)
                        {
                            mitko += int.Parse(currentLine[b].ToString());
                        }
                        else
                        {
                            vlado += int.Parse(currentLine[b].ToString());
                        }
                    }
                }
                else
                {
                    for (int b = 0; b < currentLine.Length; b++)
                    {
                        if (b < currentLine.Length / 2)
                        {
                            mitko += int.Parse(currentLine[b].ToString());
                        }
                        else if (b > currentLine.Length / 2)
                        {
                            vlado += int.Parse(currentLine[b].ToString());
                        }
                        else if (b == currentLine.Length / 2)
                        {
                            mitko += int.Parse(currentLine[b].ToString());
                            vlado += int.Parse(currentLine[b].ToString());
                        }

                    }
                }

                currentLine = string.Empty;
            }


            if (mitko > vlado)
            {
                Console.WriteLine("M " + (mitko - vlado));
            }
            else if(vlado > mitko)
            {
                Console.WriteLine("V " + (vlado - mitko));
            }
            else
            {
                Console.WriteLine("No " + (vlado + mitko));
            }
           
        }
    }
}
