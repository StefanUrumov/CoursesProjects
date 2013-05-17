using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShipDamage
{
    class DoDamage
    {

        static void Main()
        {
         int totalDamage = 0;
         int Sx1 = Int32.Parse(Console.ReadLine());
         int Sy1 = Int32.Parse(Console.ReadLine());
         int Sx2 = Int32.Parse(Console.ReadLine());    
         int Sy2 = Int32.Parse(Console.ReadLine());    
         int H = Int32.Parse(Console.ReadLine());    
         int Cx1 = Int32.Parse(Console.ReadLine());    
         int Cy1 = Int32.Parse(Console.ReadLine());    
         int Cx2 = Int32.Parse(Console.ReadLine());    
         int Cy2 = Int32.Parse(Console.ReadLine());    
         int Cx3 = Int32.Parse(Console.ReadLine());    
         int Cy3 = Int32.Parse(Console.ReadLine());          
         
         int minX = Math.Min(Sx1, Sx2);    
         int maxX = Math.Max(Sx1, Sx2);    
         int minY = Math.Min(Sy1, Sy2);    
         int maxY = Math.Max(Sy1, Sy2);

         Cy1 = 2 * H - Cy1;
         Cy2 = 2 * H - Cy2;
         Cy3 = 2 * H - Cy3;
         
    
         if ((Cx1 == minX || Cx1 == maxX) && (Cy1 == minY || Cy1 == maxY))    
         {    
             totalDamage += 25;    
         }    
         if ((Cx2 == minX || Cx2 == maxX) && (Cy2 == minY || Cy2 == maxY))    
         {    
             totalDamage += 25;    
         }    
         if ((Cx3 == minX || Cx3 == maxX) && (Cy3 == minY || Cy3 == maxY))    
         {    
             totalDamage += 25;     
         }




         if ((Cx1 > minX) && (Cx1 < maxX) && (Cy1 > minY) && (Cy1 < maxY))
         {
             totalDamage += 100;
         }
         if ((Cx2 > minX) && (Cx2 < maxX) && (Cy2 > minY) && (Cy2 < maxY))
         {
             totalDamage += 100;
         }
         if ((Cx3 > minX) && (Cx3 < maxX) && (Cy3 > minY) && (Cy3 < maxY))
         {
             totalDamage += 100;
         }
    
         
    
         if (((Cx1 == minX || Cx1 == maxX) && (Cy1 > minY && Cy1 < maxY)) || ((Cy1 == minY || Cy1 == maxY) && (Cx1 > minX && Cx1 < maxX)))    
         {    
             totalDamage += 50;     
         }    
         if (((Cx2 == minX || Cx2 == maxX) && (Cy2 > minY && Cy2 < maxY)) || ((Cy2 == minY || Cy2 == maxY) && (Cx2 > minX && Cx2 < maxX)))
         {    
             totalDamage += 50;     
         }    
         if (((Cx3 == minX || Cx3 == maxX) && (Cy3 > minY && Cy3 < maxY)) || ((Cy3 == minY || Cy3 == maxY) && (Cx3 > minX && Cx3 < maxX)))
         {    
             totalDamage += 50;    
         }
    
    
         Console.WriteLine(totalDamage + "%");
    
            
        }
    }
}
