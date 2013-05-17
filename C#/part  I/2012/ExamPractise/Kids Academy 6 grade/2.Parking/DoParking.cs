using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Parking
{
    class DoParking
    {
        static string parkingMap;
        static string sequence; 
        static int freeSpaces;
        static int oneCar;
        static int twoCars;
        static int threeCars;
        static int fourCars;

        static void Main()
        {
            //can be solved using (matrix)labirynth's debth and breath search logic
            // not working properly count more-cars-less-free-spaces, need to fix  if-statements 

            Console.WriteLine("Enter rows and columns of the parking usig space (2 <= rows cols <= 100)");
            string parking = Console.ReadLine();

            byte rows = byte.Parse(parking[0].ToString());
            byte cols = byte.Parse(parking[2].ToString());
            Console.WriteLine("- use X to mark parked cars,");
            Console.WriteLine("- use # to mark buildings,");
            Console.WriteLine("- use . to mark free space!");

            freeSpaces = 0;
            oneCar = 0;
            twoCars = 0;
            threeCars = 0;
            fourCars = 0;
            sequence = " ";

            for (int r = 0; r < rows; r++)
            {
                //for (int c = 0; c < cols; c++)
                //{
                    parkingMap = Console.ReadLine();
                    CountPlaces();                    
                //}
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void CountPlaces()
        {
            char[] parkingLot = parkingMap.ToCharArray();
            
            //single index check
            for (int index = 1; index < parkingLot.Length; index++)
            {
                if (parkingLot[index] != parkingLot[index - 1])
                {
                    if (parkingLot[index] == '.')
                    {
                        freeSpaces++;
                    }
                    if (parkingLot[index] == 'X')
                    {
                        oneCar++;
                    }
                }                
            }
            Console.WriteLine("{0} free parking spaces", freeSpaces);
            Console.WriteLine("{0} single-parked cars", oneCar);

            //sequence check - must add 1
            for (int index = 1; index < parkingLot.Length; index++)
            {
                if (parkingLot[index] == parkingLot[index - 1])
                {
                   // Console.WriteLine(parkingLot[index]);
                    if (parkingLot[index] == 'X')
                    {
                        sequence += parkingLot[index];
                        //Console.Write(sequence + '*' + ' ');
                        //Console.WriteLine(parkingLot[index]);                       
                        continue;
                    }   
                    sequence += ' ';
                }                
            }



            //Console.WriteLine(sequence);
            string [] seqStr = sequence.Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in seqStr)
            {
                //Console.Write(item + " " + item.Length + " ");
                if (item.Length == 1)
                {
                    twoCars++;
                }
                if (item.Length == 2)
                {
                    threeCars++;
                }
                if (item.Length == 3)
                {
                    fourCars++;
                }
            }
            Console.WriteLine("{0} two-parked cars", twoCars);
            Console.WriteLine("{0} three-parked cars", threeCars);
            Console.WriteLine("{0} four-parked cars", fourCars);
        }
        


        //can count only free/used parking spaces without the buildings
        /*
        static void CountPlaces()
        {
            char[] parkingLot = parkingMap.ToCharArray();
            foreach (var place in parkingLot)
            {
                if (place == '.')
                {
                    freeSpaces++;
                }
                if (place == 'X')
                {
                    oneCar++;
                }
            }
        }
         */




    }
}
