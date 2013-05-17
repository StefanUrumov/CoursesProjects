using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FighterAttack
{
    class CalculateAttack
    {
        static void Main()
        {            
            int Px1 = int.Parse(Console.ReadLine());           
            int Py1 = int.Parse(Console.ReadLine());           
            int Px2 = int.Parse(Console.ReadLine());          
            int Py2 = int.Parse(Console.ReadLine());            
            int Fx = int.Parse(Console.ReadLine());            
            int Fy = int.Parse(Console.ReadLine());            
            int D = int.Parse(Console.ReadLine());
                        
            int hit = Fx + D;

             if ((Fy >= Py2 + 2 || Fy <= Py1 - 2) && (hit > Px2 || hit < Px1 - 2)) 
            {                
                Console.WriteLine(0 + "%");
            }
            else
            {
              if ((hit >= Px1 && hit <= Px2) && (Fy < Py1 - 1 && Fy > Py1 - 2)) 
            {                
                Console.WriteLine(50 + "%");
            }
            if ((hit >= Px1 && hit <= Px2) && (Fy > Py2 && Fy < Py2 + 2)) 
            {
                Console.WriteLine(50 + "%");
            }
            if ((hit < Px1 && hit > Px1 - 2) && (Fy >= Py1 || Fy <= Py2))
            {                
                Console.WriteLine(75 + "%");
            }
            if ((hit >= Px1 && hit < Px2) && ((Fy == Py1) || (Fy == Py2))) 
            {               
                Console.WriteLine(225 + "%");
            }
            if ((hit >= Px1 && hit < Px2) && ((Fy > Py1) && (Fy < Py2)))
            {
                Console.WriteLine(275 + "%");
            }
            if (hit == Px2 && ((Fy == Py1) || (Fy == Py2)))
            {
                Console.WriteLine(150 + "%");
            }
            if (hit == Px2 && ((Fy > Py1) && (Fy < Py2)))
            {
                Console.WriteLine(275 + "%");
            }  
            }
        }              

    }
}
