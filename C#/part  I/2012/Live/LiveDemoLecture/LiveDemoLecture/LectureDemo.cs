using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDemoLecture
{
    class LectureDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 % 2);

            Console.WriteLine(1.5 / 0.0);

           //try
           //{
           //    Console.WriteLine( 5 / Convert.ToInt32("0"));
           //}
           //catch (System.DivideByZeroException dbze)
           //{
           //    Console.WriteLine("Message = {0}", dbze.Message);
           //    Console.WriteLine("Stacktrace = {0}", dbze.StackTrace);
           //    Console.WriteLine("Source = {0}", dbze.Source);
           //}
           //catch (System.Exception e)
           //{
           //    Console.WriteLine("Message = {0}", e.Message);
           //    Console.WriteLine("Stacktrace = {0}", e.StackTrace);
           //    Console.WriteLine("Source = {0}", e.Source);                
           //}


            string someString = "EKostadinov";
            Console.WriteLine("The 4th symbol of {0} is {1}", someString, someString[4]);
            Console.WriteLine("The length is: " + someString.Length + " "+ "symbols");

        }
    }
}
