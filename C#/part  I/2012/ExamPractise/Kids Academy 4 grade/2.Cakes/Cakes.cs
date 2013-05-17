using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cakes
{
    class Cakes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kids: ?");
            short kids = short.Parse(Console.ReadLine());
            Console.WriteLine("Pieces per cake: ?");
            short pieces = short.Parse(Console.ReadLine());
            
            int cakes =  kids / pieces;

            if (kids % pieces <= pieces && kids % pieces != 0) 
            {
                cakes += 1;
            }
            if (kids /pieces == 0)
            {
                cakes = 1;
            }                                                
            Console.WriteLine(cakes);
        }
    }
}
