using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            //int a = 0x10; //hexadecimal numeric system
            //int b = 0x2;  // 16x0^0 + 16x1^1
            //              // a<<b = ax2^b
            //              //n^0 = 1
            //              //n^1 = n
            //              //n^2 = n*n
            //
            //char c = 'b';
            //Console.WriteLine((int)c); //print ASCII value(as number)
            //
            //
            //float d = 0.33f;
            //float e = 1f;
            //double sum = 1.33;
            //Console.WriteLine(d + e == sum); //False - can't directly compare floating types



            //string quotation = "\"Hello, Lilly\", he said.";
            //string path = "C:\\WINNT\\Darts\\Darts.exe";
            //string quotation = @"""Hello, Jimmy!"", she answered."; //after @ everything is read as it seen (exp."""" = "") 
            //string path = @"C:\WINNT\Darts\Darts.exe";
            //
            //Console.WriteLine(quotation);
            //Console.WriteLine(path);

            //int? someInteger = null;
            //Console.WriteLine(
            //  "This is the integer with Null value -> " + someInteger);
            //someInteger = 5;
            //Console.WriteLine(
            //  "This is the integer with value 5 -> " + someInteger);

            //char one = '1';
            //char two = '2';
            //char three = '3';            
            //Console.WriteLine(one - '0'); //act like math -
            //Console.WriteLine(one + two + three); //output = 150


            //string a = "12";
            //int b = 12;
            //Console.WriteLine(a == b.ToString()); //else compile-time error

            //int a = 2;
            //int b = 16;
            //Console.WriteLine(Math.Pow(b,0));
        
            //double a = 0.2;
            //decimal b = 0.3m;
            //Console.WriteLine(a+b); // compile-time error because of the different floating point precision

            //int a = 123;
            //long b = 100000L;
            //Console.WriteLine(a+b);// result







            //double a = 0.0f;
            //double b = 0.0;
            //
            //for (int i = 0; i < 12; i++)
            //{
            //    a += 0.1;
            //}
            //
            //for (int i = 0; i < 4; i++)
            //{
            //    b += 0.3;
            //}
            //
            //Console.WriteLine(a==b); //True because float is stored in the bigger double 
                                    // if compared directly will be False (again precision problem)
            
            //int a = 2, b = 3;
            //Console.Write("{0} + {1} =", a, b); //print and stay at this line
            //Console.WriteLine(" {0}", a + b); //print on the same line but moves next operation to a new line








            //string input = Console.ReadLine();
            //long a = long.Parse(input);
            //Console.WriteLine(a); 

            //Console.Write("Full line {0}", 1, 2); //output: 1











            
            //int a = 1;
            //int b = 1;
            //switch (a)
            //{
            //    case 1:
            //        b = 2;break;
            //    case b:             //must be constant value
            //        a = 2;break;
            //    case a = 3:         //no variables!
            //        a = 3;break;
            //    
            //    
            //    default:
            //        break;
            //}





            //int number = 5;
            //if (number++ == ++number) //first time we have 5 == 6, so must be else statement
            //{                           // number has become =6, 
            //    Console.WriteLine(number + 1);
            //}
            //else
            //{
            //    Console.WriteLine(number + 2); // now add 2 and ++ from the previous if-line
            //}

            
            
            //for (int i = 1; i <= 4; i = i * 2)    // for (int i = 1; i <= 4; )
            //{                                     // {
            //    Console.Write(i + " ");           //    Console.Write(i + " ");
            //}                                     //    i = i * 2;
                                                    // }
                                                    //OUTPUT: i = 1 2 4;






            //int count = 0;
            //for (int i = 1, j =2; i < j; i++, j++) // i++ is never updated because we have brake
            //{                                       //the for loop is executed just once!
            //    count++;
            //    if (i == 3) i++; break;            //break is OUTSIDE of the if-statament    
            //}
            //Console.WriteLine(count);


           


            



        }
    }
}
