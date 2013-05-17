using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SomeAnimals
{
    interface IAnimal
    {
        string name { get; set; }
        string sex { get; set; }
        double age { get; set; }
    }
}
