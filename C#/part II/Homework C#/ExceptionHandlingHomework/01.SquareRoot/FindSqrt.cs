using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class FindSqrt
    {
        // according to http://www.dreamincode.net
        //  Math.sqrt() does not throw any exceptions

        static void Main()
        {
            Console.WriteLine("Enter positive integer: ");
            try
            {
                double num = int.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    throw new Exception("Invalid Number!");                    
                }
                double sqrtNum = Math.Sqrt(num);
                Console.WriteLine("Square root of {0} is: {1}", num, sqrtNum);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Message: {0}", ae.Message);
                throw new Exception("Invalid Number!"); 
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
            

            
        }
    }
}
