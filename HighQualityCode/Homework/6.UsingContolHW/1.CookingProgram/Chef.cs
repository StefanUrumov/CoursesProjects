
namespace _1.CookingProgram
{
    using System;
    using System.Linq;

    public class Chef
    {
        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Cut(IVegetable cookingProduct)
        {
            Console.WriteLine("Cutting");
        }

        private void Peel(IVegetable cookingProduct)
        {
            Console.WriteLine("Peeling");
        }

        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            
            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);
            
            Bowl bowl = GetBowl();
            
            bowl.Add(carrot);
            bowl.Add(potato);
        }       
    }
}
