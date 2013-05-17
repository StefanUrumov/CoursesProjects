using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SomeAnimals
{
    interface ICat :IAnimal,ISound
    {
        string owner { get; set; }
        string personalId { get; set; }
        string color { get; set; }
        string breed { get; set; }

        void GoForAWalk();
        void BeHungry();
        void Prrr();
    }
}
