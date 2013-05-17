using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class SomePractise
    {
        static void Main()
        {
            //int a = 0x10; //hexadecimal numeric system
            //int b =  0x2;  // 16x0^0 + 16x1^1
            //int res = a<<b; // = ax2^b
            //              //n^0 = 1
            //              //n^1 = n
            //              //n^2 = n*n
            
            //char c = 'c';
            //Console.WriteLine((int)c); //print ASCII value(as number)
                        
                        
            //float d = 0.33f;
            //float e = 1f;
            //double sum = 1.33;
            //Console.WriteLine(d + e == sum); //False - can't directly compare floating types
            

           //string quotation = "\"Hello, Lilly\", he said.";
           //string path = "C:\\WINNT\\Darts\\Darts.exe";
           //string quotation = @"""Hello, Jimmy!"", she answered."; //after @ everything is read as it seen (exeption."" = ") 
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
            //Console.WriteLine(Math.Pow(b,a));
            //Console.WriteLine(Math.Sqrt(a)); //output in double
        
            //double a = 0.2;            
            //decimal b = 0.3m;
            //Console.WriteLine(a + b); // compile-time error because of the different floating point precision


            //int a = 123;
            //long b = 100000;
            //Console.WriteLine(a+b);// result

            //int a = 100000000;
            //int b = 9000000000; //can calculate if it is bigger than int, before run-time
            //Console.WriteLine(a+b);


            //double a = 0.0f;
            //double b = 0.0;
            //
            //for (int i = 0; i < 12; i++)
            //{
            //    a += 0.1; //if +=0.1f compilation error
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
            
            //Console.WriteLine("This is a test string {0}{1}", 11);  //run-time error - can't find second element 
                                                                    //for the second placeholder            



            //int a = 1;
            //int b = 1;
            //switch (a) //if a == 2 compilation error - can't convert bool to int
            //{
            //    case 1:
            //        b = 2;break;
            //    case b:             //must be constant value
            //        a = 2;break;
            //    case a = 3:         //no variables!
            //        a = 3;break;
            //    case null:          //can't be null when int
            //        a = 5;break;                
            //    default:
            //        break;
            //}


            //int? a = null;
            //switch (a)                   //if null => compilation error
            //{
            //    case 5:
            //        Console.WriteLine(5);
            //        break;
            //    case null:                    //case can be null !!!
            //        Console.WriteLine(3);
            //        break;
            //    default:
            //        Console.WriteLine(0);
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

            
            
            //for (int i = 1; i <= 4; i = i * 2)    //for (int index = 1; index <= 4; )
            //{                                     //{
            //    Console.Write(i + " ");           //   Console.Write(index + " ");
            //}                                     //   index = index * 2;
                                                    //}
                                                    //OUTPUT: i = 1 2 4;
            
            //int count = 0;
            //for (int i = 1, j =2; i < j; i++, j++) // i++ is never updated because we have brake
            //{                                       //the for loop is executed just once!
            //    count++;
            //    if (i == 3) i++; break;            //break is OUTSIDE of the if-statament    
            //}
            //Console.WriteLine(count);


            //int i = 100, sum = 0; 
            //for (; i >= 1; i--)     //count back from 100
            //{
            //    sum += i;
            //    Console.WriteLine(sum);
            //}

            //int a = 2;
            //double b = 3.1;
            //Console.WriteLine(a+b);
            // output 5.1 = double
            

            //for (int i = 0; i < 10; i++) //print the first 10 odd numbers
            //Console.WriteLine(i * 2 + 1);

            //string s = "\"hello!\"\n";      //the new line is count as 1
            //Console.WriteLine("{0}", s.Length); //each escaping symbol is not seen
                                                //output = 9

            //Random rand = new Random();
            //int number = rand.Next(100); //will return random number 0..100
            //Console.WriteLine(number);

            //int age = int.Parse(Console.ReadLine());
            //int student = int.Parse(Console.ReadLine());
            //bool freePass = true;                           //compile-time error
            //freePass = age < 15 || (age <25 && student);    //can not use && on bool and int 

            //bool more = true;         //read from console untill 'q' is entered
            //while (more)
            //{	
	        //more = Console.ReadLine() != "q";
            //}

            //double double Test = 1.23232f; //compilation error
            //Console.WriteLine(Test);


            //int? test = null;
            //int? test1 = null;
            //Console.WriteLine(test + test1);
            //Console.WriteLine(test1 + 123); //OUTPUT 2 empty lines

            //int x = 5;
            //int count = 100;
            //while (count > 0)
            //{
            //    count--;
            //    x++;
            //    if (x>0)
            //    {
            //        x = x - 2;
            //    }
            //}
            //Console.WriteLine(x);  //OUTPUT -1

            //int? a = null;
            //string b = a.ToString();
            //Console.WriteLine(b);

          

            //Console.Write(Environment.NewLine); //also create new line

            //byte num1 = 95;
            //byte num2 = 1;
            //byte res = num1 + num2; //compilation error
            //Console.WriteLine(res);

            //int test = 0x8;
            //int test2 = 0x7;
            //Console.WriteLine((char)test + (char)test2); //output = 15

            //object a = 1;
            //object b = 2;
            //Console.WriteLine("null" + a + b);


            //int 9Test = 0;        //compilation error
            //int new = 2;           //compilation error
            //int more_Test = 3;
            //int _testMe = 9;


            //int a = 100, b = 200, c = 300;           //if all True res = c
            //int res = a < b ? a > c ? c : a : b;     //if all False res = b;
            //Console.WriteLine(res);                  //if first True res = a;
                                                     //if second True res = b;


            //ushort a = 1500u; //compilation error 'u' is for uint 
            //ushort b = 4;


            //string a = Console.ReadLine();    //if only Enter is pressed
            //Console.WriteLine(a);             //readline will return string


           //string name = null;
           //Console.WriteLine(name ?? "(no name)"); //output: (no name)
           // ?? проверява дали стойността на string-а е null и ако е null изписва това 
           //което си му дал в кавичките(no name), ако не е null(например ako беше string name = "Ivan";)
           // изкарва това което е в стринга "Ivan"


            //int? a = null; //if a is !null res = a
            //int res = a ?? 5;
            //Console.WriteLine(res);

            //int? a = null; 
            //int res = a ?? 5.5;  //compile-time error, can't implicitly convert double to int
            //Console.WriteLine(res);

            //int a = 5;
            //int? b = a;
            //a = b; //compilation error can't implicitly int? to int
            //Console.WriteLine(b);
            

            //int mask = 1;
            //if (mask & 1 == 1) //& can't be applied to int and bool
            //{
            //    Console.WriteLine(mask);
            //}

            //int a = new int();                //run-time error
            //int b = 123;
            //int c = 0;
            //
            //for (int i = 0; i < 10; i++)
            //{
            //    c += i - 2;
            //}
            //Console.WriteLine(b - (c / a)); //can't divide by zero


            //int? myInt = null;                  //run-time error
            //Console.WriteLine(myInt.Value);
            //методът variable.Value се опитва по време на изпълнение на 
            //програмата да вземе стойността на myInt, но тя на практика е празна (myInt = null)

            //int a  = 2;
            //int b = 3;
            //double res = b / a; //they are still int!
            //Console.WriteLine(res); //output: 1

            //string animal = "animal";
            //switch (animal)
            //{
            //    case "dog":
            //    case "cat":
            //    case "bird":
            //        Console.WriteLine("yes!");break;
            //    case "car":
            //        Console.WriteLine("no");break;
            //    default:
            //        break;
            //}


           //bool a = false;
           //bool b = false;
           //bool d = true;
           //bool c = false;
           //bool e = true;
           //
           //Console.WriteLine(a ? b : c ? d : e); //output: True

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2 == 0 && i % 5 == 0)
            //    {
            //        break;
            //    }
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //int res = 1;
            //for (int i = 0; i < 56; i++)
            //{
            //    res *=16;
            //    for (int j = 0; j < 4; j++)  // if i++ ENDLESS loop
            //    {
            //        res /= 2;               //res always will be 1
            //    }
            //}
            //Console.WriteLine((++res)<<1); // 2 * 2^1 



            //int a = 2;
            //int b = 3;
            //double res = b / a; //a and b are still int
            //Console.WriteLine(res); //output: 1

            //same for
            //int a = 2;
            //int b = 3;
            //decimal res = b / a; 
            //Console.WriteLine(res); 


            //Console.WriteLine("{0:D6}", 123); // 000123


            //int a = 5;
            //int? b = a; //if null run-time error
            //a = b.Value;
            //Console.WriteLine(a);

            //int? a = null;
            //if (a.HasValue)
            //{
            //    Console.WriteLine(false);
            //}
            //else
            //{
            //    Console.WriteLine(true); //OUTPUT: True
            //}


            //Console.WriteLine(Convert.ToInt32(null)); //OUTPUT: 0
            

            //int res = 1;
            //for (int i = 0; i < int.MaxValue/4; i++)
            //{
            //    res += 4;
            //}
            //if (res > 0)
            //{
            //    Console.WriteLine("No overflow"); //correct
            //}
            //else
            //{
            //    Console.WriteLine("Overflow");
            //}


            //double b = 0; //if int run-time error
            //Console.WriteLine(10/b); // + Infinity

            //double a = 0;
            //double b = 0;
            //Console.WriteLine(a/b); //NaN

            //int a = 0;
            //int b = 0;
            //Console.WriteLine(a/b); //run-time error, attempt to divide by zero 
        

            //string formating = "{0},{1}";
            //Console.WriteLine(formating, 10, 20 );


            //int a = int.MaxValue; //if uint output = 0
            //a += 1;
            //Console.WriteLine(a); //no exeption

            //int res = 1;
            //for (int i = 0; i <= int.MaxValue/4; i++)
            //{
            //    res += 4;
            //}
            //Console.WriteLine(res);
            //NO EXEPTION is thrown

            //int a = 5;
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine(1);break;
            //
            //    case 2:
            //        Console.WriteLine(2); break;
            //    case 3:
            //        Console.WriteLine(3); break;
            //    case 4:
            //        Console.WriteLine(4); break;
            //}
            //nothing happens

            //int a = 1;
            //int b = 2;
            //int c = 3;
            //int d = 4;
            //int res = a = b = c = d;
            //Console.WriteLine(res); //output: 4

            //double a = 27.123;
            //float b = 21.1234f;
            //int result = (int)a ^ (int)b;
            

            //Console.WriteLine("{0:x}", 255);
            //output: ff


            //string a = "Telerik";
            //string sub = a.Substring(0, 3);
            //Console.WriteLine(sub);
            //output: Tel

            //Console.WriteLine(int.Parse(null)); //run-time error

            //int res = 0;
            //for (double i = 0; i < 1; )
            //{
            //    res += 1;
            //    i += 0.1;
            //}
            //Console.WriteLine(res);
            //output: 11, not 9 or 10
        
        //char a ='/u003A'; //compilation error, must be \
        //Console.WriteLine(a);


           //decimal a = new decimal(null);   
           //Console.WriteLine(uint.MaxValue/a);  //run-time error

            //int k = 0;
            //int h = 3;
            //int g = h - k;
            //int a = 6;
            //int c = 8;
            //int d = 9;
            //int e = b; //compilation error - using local variable before it's declared
            //int b = 3;
            //Console.WriteLine((h + b) / k); //else run-time error


            //byte a = -10; //compilation error, must be sbyte
            //var b = 50 << a;
            //Console.WriteLine(b);

            //bool equal = !new bool();
            //equal = !equal & new bool();
            //bool checkEqual = (!new bool() & equal);
            //Console.WriteLine(checkEqual);

            //double a = 1.000025;
            //double b = 0.000025;
            //Console.WriteLine((a - b) == 1); //output: False

            //bool boolean = Convert.ToBoolean("25"); //run-time error
            //Console.WriteLine(boolean);


            //int sum = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    sum++; sum++;
            //}
            //Console.WriteLine(sum);

           //int sum = 0;
           //while (sum < 10)
           //{
           //    for (int i = 0; i < 4; i++)
           //    {
           //        sum++; 
           //    }
           //}
           //Console.WriteLine(sum);
        }
    }
}
