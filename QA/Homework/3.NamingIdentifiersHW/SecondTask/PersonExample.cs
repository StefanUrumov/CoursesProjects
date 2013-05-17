using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class PersonExample
    {
        static void Main()
        {
            Person human = new Person();
            human.CreatePerson(23);
            Console.WriteLine(human.ToString());

            human.CreatePerson(42);
            Console.WriteLine(human.ToString());
        }
    }
}
