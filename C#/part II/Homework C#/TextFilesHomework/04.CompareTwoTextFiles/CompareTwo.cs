using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.CompareTwoTextFiles
{
    class CompareTwo
    {
        static void Main()
        {
            string path1 = "../../test.txt";
            string path2 = "../../test2.txt";

            int diff = 0;
            int equal = 0;            

            using (StreamReader first = new StreamReader(path1))
            {
                using (StreamReader second = new StreamReader(path2))
                {
                    string firstLine = first.ReadLine();
                    string secondLine = second.ReadLine();

                    while (firstLine != null && secondLine != null)
                    {
                        if (firstLine != secondLine)
                        {
                            diff++;
                        }
                        else
                        {
                            equal++;
                        }

                        firstLine = first.ReadLine();
                        secondLine = second.ReadLine();
                    }
                }
                Console.WriteLine("Different lines: {0}", diff);
                Console.WriteLine("Equal lines {0}", equal);

            }

        }
    }
}
