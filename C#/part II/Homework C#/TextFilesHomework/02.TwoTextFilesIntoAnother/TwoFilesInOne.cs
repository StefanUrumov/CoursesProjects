using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.TwoTextFilesIntoAnother
{
    class TwoFilesInOne
    {
        static void Main()
        {

             string path1 = "../../test.txt";
             string path2 = "../../test2.txt";
             string newFile ="../../final.txt";

             StreamReader fiFile = new StreamReader(path1);
             StreamReader secFile = new StreamReader(path2);

             using (fiFile)
             {
                 string first = fiFile.ReadToEnd();
                 Console.WriteLine("First file: \n {0}",first);

                 using (secFile)
                 {
                     string second = secFile.ReadToEnd();
                     Console.WriteLine("Second file \n {0}", second);

                     string all = first + "\n" + second;
                     File.WriteAllText(newFile, all);

                     Console.WriteLine("All text: ");
                     Console.WriteLine(all);
                     
                 }

             }
            
        }

    }
}
