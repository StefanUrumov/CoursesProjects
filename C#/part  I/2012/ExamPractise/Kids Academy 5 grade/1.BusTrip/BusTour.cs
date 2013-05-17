using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BusTrip
{
    class BusTour
    {
        static void Main()
        {
            Console.WriteLine("Enter width and heigth of the bus (w h):");
            string bus = Console.ReadLine();
            var parameters = bus.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int w = int.Parse(parameters[0]);
            int h = int.Parse(parameters[1]);


            Console.WriteLine("Enter yhe number of the obstacles: ");
            byte obstacles = byte.Parse(Console.ReadLine());


            for (int index = 1; index <= obstacles; index++)
            {
                Console.WriteLine("Enter width and heigth of the obstacle (w h):");
                string obsticleStr = Console.ReadLine();
                var obstacleVar = obsticleStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int a = int.Parse(obstacleVar[0]);
                int b = int.Parse(obstacleVar[1]);

                if (w > a || h > b)
                {
                    Console.WriteLine(index);
                }
                if (w <= a && h <= b)
                {
                    Console.WriteLine("No crash!");
                }
            }

        }
    }
}
