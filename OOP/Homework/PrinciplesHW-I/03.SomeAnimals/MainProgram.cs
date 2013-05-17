using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SomeAnimals
{
    class MainProgram
    {
        static void Main()
        {
            Dog Manny = new Dog();
            Manny.age = 2.5;
            Manny.breed = "Chow Chow";
            Manny.color = "Red";
            Manny.name = "Manny";
            Manny.owner = "Me";
            Manny.personalId = "dog123";
            Manny.sex = "Male";

            Console.WriteLine("Your Dog is called {0} it's {1} years old, the breed is: {2}. The color of the dog is: {3} and the owner is: {4}. The dog is: {5} with personal id {6}.", Manny.name, Manny.age, Manny.breed, Manny.color, Manny.owner, Manny.sex, Manny.personalId);
            Manny.WagTail();
            Console.WriteLine( Manny.SayBau() );
            Console.WriteLine( Manny.MakeNoise() );
            Manny.GoForAWalk();
            Manny.BeHungry();

            List<Dog> dogs = new List<Dog>
            {
                new Dog("Dog", 1.2),
                new Dog("Dogg", 2.4),                
                new Dog("Dogy", 3.2),
                new Dog("Doggy", 1.4),  
                new Dog("Dogo", 5.2),
                new Dog("Doggo", 6.4),
                new Dog("Dooog", 2.2),
                new Dog("Doooogg", 3.4),                
                new Dog("Doga", 3.5),
                new Dog("Dogga", 7.4)
            };

            Console.WriteLine("Average age of dogs is: {0}", dogs.Average(dog => dog.age));

            List<Frog> frogs = new List<Frog>
            {
                new Frog("Gogo", 0.2),
                new Frog("Gogi", 0.3),
                new Frog("Go", 0.1),
                new Frog("Gog", 0.5),
                new Frog("Gogooo", 0.4),                
                new Frog("Googo", 0.6),
                new Frog("G", 0.8),
                new Frog("Gmogo", 0.7),
                new Frog("Gmo", 0.9),
                new Frog("Gmog", 1.2),
            };

            Console.WriteLine("Average age of frogs is: {0}", frogs.Average(frog => frog.age));


        }
    }
}
