using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ushort five =    ushort.Parse(Console.ReadLine());
            ushort ten =     ushort.Parse(Console.ReadLine());
            ushort twenty =  ushort.Parse(Console.ReadLine());
            ushort fifty =   ushort.Parse(Console.ReadLine());
            ushort oneCoin = ushort.Parse(Console.ReadLine());

            decimal amount =  decimal.Parse(Console.ReadLine());
            decimal price =   decimal.Parse(Console.ReadLine());

            decimal total = (five * 0.05m) + (ten * 0.10m) + (twenty * 0.20m) + (fifty * 0.50m) + (oneCoin * 1.00m);
                   

            //have change
            if (price <= amount && total >= amount)
            {
                Console.WriteLine("Yes " + (total - (amount - price))); //{0:0.00}
            }
            //not enough amount
            else if (price > amount)
            {
                Console.WriteLine("More " + (price - amount));
            }
            //no change in the machine
            else if (amount > price && (amount - price) > total) //maybe add -> || amount >= price
            {
                Console.WriteLine("No " + ((amount - price) - total));
            }
        }
    }
}
