using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Person
{
    class MainProgram
    {
        static void Main()
        {
            Person p = new Person("Vader");
            Person p1 = new Person("Smoke", null);
            Person p2 = new Person("Kano", 32);

            Console.WriteLine(p); //invokes ToString() method automatically
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
