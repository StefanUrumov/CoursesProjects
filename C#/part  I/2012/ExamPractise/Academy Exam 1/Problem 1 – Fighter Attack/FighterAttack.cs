using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Fighter_Attack
{
    class FighterAttack
    {
        static int Px1;
        static int Py1;
        static int Px2;
        static int Py2;
        static int Fx;
        static int Fy;
        static int D;       
        static int TotalDamage;
        static int hit;

        static void Main()
        {
            Console.WriteLine("Enter value for Px1:");
            Px1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Py1:");
            Py1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Px2:");
            Px2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Py2:");
            Py2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Fx:");
            Fx = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Fy:");
            Fy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for D:");
            D = int.Parse(Console.ReadLine());

            TotalDamage = 0;
            hit = Fx + D;
           
            FindFighter();
        
        }

        private static void FindFighter()
        {
            if ((Fy >= Py2 + 2 || Fy <= Py1 - 2) && (hit > Px2 || hit < Px1 - 2)) //check if fighter and missile are missing the plant
            {
                Console.WriteLine("Missile had missed the target plant!");
                Console.WriteLine("Total damage on target: 0%");
            }
            else
            {                
                CalculateDamage();
            }

        }

        private static void CalculateDamage()
        {
            if ((hit >= Px1 && hit <= Px2) && (Fy < Py1 -1 && Fy > Py1 - 2)) //check if target  is hit next to bottom/right side
            {
                Console.WriteLine("Missile did collateral damage to the target plant!");
                Console.WriteLine("Total damage on target: 50%");
            }
            if ((hit >= Px1 && hit <= Px2) && (Fy > Py2 && Fy < Py2 + 2)) //check if target is hit next to top/left side
            {
                Console.WriteLine("Missile did collateral damage to the target plant!");
                Console.WriteLine("Total damage on target: 50%");
            }
            if ((hit < Px1 && hit > Px1 - 2) && (Fy >= Py1 || Fy <= Py2 ))
            {
                Console.WriteLine("Missile did collateral damage to the target plant!"); //check if target is hit in front
                Console.WriteLine("Total damage on target: 75%");
            }
            if ((hit >= Px1 && hit < Px2) && ((Fy == Py1) || (Fy == Py2))) //code below calculates direct hit
            {
                Console.WriteLine("Direct hit! Missile did damage to the target plant!"); 
                Console.WriteLine("Total damage on target: 225%");
            }
            if ((hit >= Px1 && hit < Px2) && ((Fy > Py1) && (Fy < Py2)))
            {
                Console.WriteLine("Direct hit! Missile did damage to the target plant!"); 
                Console.WriteLine("Total damage on target: 275%");
            }
            if (hit == Px2  && ((Fy == Py1) || (Fy == Py2)))
            {
                Console.WriteLine("Direct hit! Missile did damage to the target plant!"); 
                Console.WriteLine("Total damage on target: 150%");
            }
            if (hit == Px2 && ((Fy > Py1) && (Fy < Py2)))
            {
                Console.WriteLine("Direct hit! Missile did damage to the target plant!");
                Console.WriteLine("Total damage on target: 275%");
            }
        }

        
    }
}
