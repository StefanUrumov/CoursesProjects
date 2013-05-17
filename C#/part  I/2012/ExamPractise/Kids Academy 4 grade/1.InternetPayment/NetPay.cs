using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.InternetPayment
{
    class NetPay
    {
        static void Main()
        {
            Console.WriteLine("Enter monthly fee: ");
            byte A = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter monthly MB traffic: ");
            byte B = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter MB overlimit tax: ");
            byte C = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter this month used MB traffic: ");
            byte D = byte.Parse(Console.ReadLine());

            int traffic = D - B;
            int overPrise = traffic * C;
            int thisMonthFee = A + overPrise;

            if (D < 2)
            {
                Console.WriteLine("This month you need to pay: {0}", A); 
            }
            else
            {
               Console.WriteLine("This month you need to pay: {0}", thisMonthFee);
            }
            



        }
    }
}
