using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies
{
    class Sweets
    {
        static void Main()
        {
            Console.WriteLine("Enter how many cookies did red ridding hood;s mom made(must be odd number): ");
            int cookies = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter hunter's fee: ");
            int hunterFee = int.Parse(Console.ReadLine());

            int wolf = cookies / 2;
            if (wolf < hunterFee)
            {
                Console.WriteLine("Pay to wolf {0}cookies and {1} left!", wolf, wolf);
            }
            else
            {
                Console.WriteLine("Pay to hunter {0}cookies and {1} left!", hunterFee, cookies - hunterFee);
            }       
        
        }
    }
}
