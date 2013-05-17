using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06.SortStringsFile
{
    class SortStrings
    {
        static List<string> strArr;
        static string result;

        static void Main()
        {
            string path = "../../test.txt";
            result = "../../result.txt";

            //PrintFirstFile(path);
            SortFileStrings(path);
        }

        private static void PrintFirstFile(string path)
        {
            StreamReader fiFile = new StreamReader(path);

            string first = fiFile.ReadToEnd();
            Console.WriteLine("First file names: ");
            Console.WriteLine(first);
        }

        private static void SortFileStrings(string path)
        {
            string line = string.Empty;

            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadLine();
                strArr = new List<string>();

                while ((line = sr.ReadLine()) != null)
                {
                    strArr.Add(line); //here i put one extra first line in the file, so i can get all real lines
                }
            }

            WriteToNewFile(strArr);
        }

        private static void WriteToNewFile(List<string> strArr)
        {
            strArr.Sort();

            using (StreamWriter writer = new StreamWriter(result))
            {
                writer.WriteLine(strArr);        
            }

            foreach (var item in strArr)
            {
                Console.WriteLine(item);
            }
        }





    }
}
