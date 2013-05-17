
namespace _1.CookingProgram
{
    using System;
    using System.Linq;

    public interface IVegetable
    {
        string Kind { get; set; }
        double Size { get; set; }
        double Weight { get; set; }
        bool IsPeeled { get; set; }
        bool IsGoodToEat { get; set; }
    }
}
