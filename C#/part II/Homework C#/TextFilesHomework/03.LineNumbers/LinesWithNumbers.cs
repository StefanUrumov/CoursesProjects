using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.LineNumbers
{
    class LinesWithNumbers
    {
        static void Main()
        {
            string path1 = "../../test.txt";
            string path2 = "../../new.txt";

            StreamReader fiFile = new StreamReader(path1);

            using (fiFile)
            {
                //string first = fiFile.ReadToEnd();
                //Console.WriteLine("First file: \n {0}", first);

                int linesNumber = 0;
                string line = string.Empty;

                StreamWriter sr = new StreamWriter(path2, false);
                using (sr)
                {
                    while ((line = fiFile.ReadLine()) != null)
                    {
                        sr.Write("line {0}: ", linesNumber);
                        sr.WriteLine(line);
                        linesNumber++;
                    }
                }
            }
        }

    }
}