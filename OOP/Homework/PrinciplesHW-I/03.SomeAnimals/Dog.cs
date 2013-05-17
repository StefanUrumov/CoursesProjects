using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SomeAnimals
{
    class Dog : IAnimal, ISound
    {
        public string name { get; set; }
        public string sex { get; set; }
        public double age { get; set; }
        public string owner { get; set; }
        public string personalId { get; set; }
        public string color { get; set; }
        public string breed { get; set; }

        public string MakeNoise()
        {
            string notHappy = "Grrrr!";
            return notHappy;
        }

        public void GoForAWalk()
        {
            Console.WriteLine("Dog is happy when is a on a walk.");
        }

        public void BeHungry()
        {
            Console.WriteLine("Your dog is hungry!");
        }

        public string SayBau()
        {
            string bau = "Bau, Bau!";
            return bau;
        }

        public void WagTail()
        {
            Console.WriteLine("Tail is wagging. Your dog is happy.");
        }

        public Dog()
        {
        }

        public Dog(string name, double age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
