
namespace _2.RefactorIfStatements
{
    using System;
    using System.Linq;
    using _1.CookingProgram;

    class DoRefactoring
    {
        static void Main(string[] args)
        {   
            //first task
            IVegetable potato = new Potato();
         
            //...           
            potato.IsPeeled = true;
            potato.IsGoodToEat = true;

            if (potato != null)
            {
               if(potato.IsPeeled && potato.IsGoodToEat)
               {
                   Cook(potato);
               }
            }
                        
            //second task
            int x = 0;
            int y = 0;
            int minX = 0;
            int maxX = 0;
            int maxY = 0;
            int minY = 0;
            bool shoudVisitCell = true;
            bool isYInRange = minY <= y && y <= maxY;
            bool isXInRange = minX <= x && x <= maxX;

            if (isXInRange && (isYInRange && shoudVisitCell))
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("I will visit the cell.");
        }

        private static void Cook(IVegetable potato)
        {
            Console.WriteLine("Cooking");
        }
    }
}
