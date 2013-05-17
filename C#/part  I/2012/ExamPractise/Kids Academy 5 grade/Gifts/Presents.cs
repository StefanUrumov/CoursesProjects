using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifts
{
    class Presents
    {
        static void Main()
        {
            Console.WriteLine("Enter meters and centimeters (1 50)");
            string line = Console.ReadLine();

            Console.WriteLine("Enter number of gifts: ");
            int gifts = int.Parse(Console.ReadLine());

            if (line[2].ToString() == "0")
            {
                Console.WriteLine(gifts * int.Parse(line[0].ToString()) + " " + "0");
            }
            else
            {
                string lineMeters = line[0].ToString();
                string lineCentimeters = line[2].ToString() + line[3].ToString();

                int meters = int.Parse(lineMeters);
                int centimeters = int.Parse(lineCentimeters);

                int resultMeters = gifts * meters;
                int resultCentimeters = gifts * centimeters; 
                
                if (resultCentimeters >= 100)
                {
                    resultMeters += 1;
                    resultCentimeters -= 100;
                    Console.WriteLine(resultMeters + " " + resultCentimeters);
                }
                else
                {
                    Console.WriteLine(resultMeters + " " + resultCentimeters);
                }
            }
            
        }
    }
}
