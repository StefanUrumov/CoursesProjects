using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SomeAnimals
{
    class Frog :IAnimal, ISound
    {
        public string name { get; set; }
        public string sex { get; set; }
        public double age { get; set; }
        public string kind { get; set; }
        public string color { get; set; }

        public string MakeNoise()
        {
            string kokak = "Kokak-Kokak!";
            return kokak;
        }

        public void Jump()
        {
            Console.WriteLine("The frog is jumping.");
        }

        public void Swim()
        {
            Console.WriteLine("The frog is swimming!");
        }

        public void Eating()
        {
            Console.WriteLine("The frog is eating bugs.");
        }

        public Frog(string name, double age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
