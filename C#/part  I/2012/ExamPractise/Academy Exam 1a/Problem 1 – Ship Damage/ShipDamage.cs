using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Ship_Damage
{
    class ShipDamage
    {
        static int Sx1;
        static int Sy1;
        static int Sx2;
        static int Sy2;
        static int H;
        static int Cx1;
        static int Cy1;
        static int Cx2;
        static int Cy2;
        static int Cx3;
        static int Cy3;
        static int totalDamage;
        static int hitC1;
        static int hitC2;
        static int hitC3;


        static void Main()
        {
            Console.WriteLine("Enter value for Sx1:");
            Sx1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Sy1:");
            Sy1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Sx2:");
            Sx2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Sy2:");
            Sy2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for H:");
            H = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Cx1:");
            Cx1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Cy1:");
            Cy1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Cx2:");
            Cx2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Cy2:");
            Cy2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Cx3:");
            Cx3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Cy3:");
            Cy3 = int.Parse(Console.ReadLine());            

            

            if ((Cx1 > Sx1 && Cx1 < Sx2) && (Cx2 > Sx1 && Cx2 < Sx2) && (Cx3 > Sx1 && Cx3 < Sx2))  //check if catapults are not in one horizontal
            {                                                                                      // line with the ship
                Console.WriteLine("Total damage to the ship: {0}", totalDamage);
            }
            else
            {
                CalculateDamage();
                Console.WriteLine(totalDamage);
            }
           
        }

        private static void CalculateDamage()
        {            
            if (Cy1 == 1 || Cy1 == -1)
            {
                hitC1 = (((Cy1 - Cy1) - Cy1) + H);
            }
            else
            {
            hitC1 = (((Cy1 - Cy1) - Cy1) + (H + H));
            }
            FirstCatapult();

            if (Cy2 == 1 || Cy2 == -1)
            {
                hitC2 = (((Cy2 - Cy2) - Cy2) + H);
            }
            else
            {
                hitC2 = (((Cy2 - Cy2) - Cy2) + (H + H));
            }
            SecondCatapult();

            if (Cy3 == 1 || Cy3 == -1)
            {
                hitC3 = (((Cy3 - Cy3) - Cy3) + H);
            }
            else
            {
                hitC3 = (((Cy3 - Cy3) - Cy3) + (H + H));
            }
            ThirdCatapult();
        }

        private static void ThirdCatapult()
        {
            if ((Cx3 == Sx1 || Cx3 == Sx2) && (hitC3 == Sy1 || hitC3 == Sy2)) //corner hit
            {
                totalDamage += 25;
            }
            if ((Cx3 == Sx1 || Cx3 == Sx2) && (hitC3 > Sy1 || hitC3 < Sy2)) //check left and rigth sides 
            {
                totalDamage += 50;
            }
            if ((hitC3 == Sy1 || hitC3 == Sy2) && (Cx3 < Sx1 || Cx3 > Sx2)) //check top and bottom sides
            {
                totalDamage += 50;
            }
            if ((Cx3 < Sx1 || Cx3 > Sx2) && (hitC3 > Sy1 && hitC3 < Sy2)) //check direct hit
            {
                totalDamage += 100;
            }
            else
            {
                totalDamage += 0;    
            }
        }

        private static void SecondCatapult()
        {
            if ((Cx2 == Sx1 || Cx2 == Sx2) && (hitC2 == Sy1 || hitC2 == Sy2)) //corner hit
            {
                totalDamage += 25;
            }
            if ((Cx2 == Sx1 || Cx2 == Sx2) && (hitC2 > Sy1 || hitC2 < Sy2)) //check left and rigth sides 
            {
                totalDamage += 50;
            }
            if ((hitC2 == Sy1 || hitC2 == Sy2) && (Cx2 < Sx1 || Cx2 > Sx2)) //check top and bottom sides
            {
                totalDamage += 50;
            }
            if ((Cx2 < Sx1 || Cx2 > Sx2) && (hitC2 > Sy1 && hitC2 < Sy2)) //check direct hit
            {
                totalDamage += 100;
            }
            else
            {
                totalDamage += 0;
            }
        }

        private static void FirstCatapult()
        {
            if ((Cx1 == Sx1 && (hitC1 == Sy1 || hitC1 == Sy2)) || (Cx1 == Sx2 && (hitC1 == Sy1 || hitC1 == Sy2))) //corner hit
            {
                totalDamage += 25;
            }
            if ((Cx1 == Sx1 && (hitC1 > Sy1 || hitC1 < Sy2)) || (Cx1 == Sx2 && (hitC1 > Sy1 || hitC1 < Sy2))) //check left and rigth sides 
            {
                totalDamage += 50;
            }
            if ((hitC1 == Sy1 && (Cx1 < Sx1 || Cx1 > Sx2)) || (hitC1 == Sy2 && (Cx1 < Sx1 || Cx1 > Sx2))) //check top and bottom sides
            {
                totalDamage += 50;
            }
            if ((Cx1 < Sx1 && (hitC1 > Sy1 && hitC1 < Sy2)) || (Cx1 > Sx2 && (hitC1 > Sy1 && hitC1 < Sy2))) //check direct hit
            {
                totalDamage += 100;
            }
            else
            {
                totalDamage += 0;
            }
        }
    }
}


/*
 * solution
 using System;
02
 
03
class ShipDamage
04
{
05
    static void Main()
06
    {
07
        // Read the input
08
        int sx1 = Int32.Parse(Console.ReadLine());
09
        int sy1 = Int32.Parse(Console.ReadLine());
10
        int sx2 = Int32.Parse(Console.ReadLine());
11
        int sy2 = Int32.Parse(Console.ReadLine());
12
        int h = Int32.Parse(Console.ReadLine());
13
        int cx1 = Int32.Parse(Console.ReadLine());
14
        int cy1 = Int32.Parse(Console.ReadLine());
15
        int cx2 = Int32.Parse(Console.ReadLine());
16
        int cy2 = Int32.Parse(Console.ReadLine());
17
        int cx3 = Int32.Parse(Console.ReadLine());
18
        int cy3 = Int32.Parse(Console.ReadLine());
19
 
20
        // Find the hit points (apply symmetrics)
21
        cy1 = 2 * h - cy1;
22
        cy2 = 2 * h - cy2;
23
        cy3 = 2 * h - cy3;
24
 
25
        // Find the ship bounds
26
        int minX = Math.Min(sx1, sx2);
27
        int maxX = Math.Max(sx1, sx2);
28
        int minY = Math.Min(sy1, sy2);
29
        int maxY = Math.Max(sy1, sy2);
30
 
31
        int totalDamage = 0;
32
 
33
        // Check the corners damage
34
        if ((cx1 == minX || cx1 == maxX) && (cy1 == minY || cy1 == maxY))
35
        {
36
            totalDamage += 25; // Hit in the corner
37
        }
38
        if ((cx2 == minX || cx2 == maxX) && (cy2 == minY || cy2 == maxY))
39
        {
40
            totalDamage += 25; // Hit in the corner
41
        }
42
        if ((cx3 == minX || cx3 == maxX) && (cy3 == minY || cy3 == maxY))
43
        {
44
            totalDamage += 25; // Hit in the corner
45
        }
46
 
47
        // Check the borders damage
48
        if (((cx1 == minX || cx1 == maxX) && (cy1 > minY && cy1 < maxY)) ||
49
            ((cy1 == minY || cy1 == maxY) && (cx1 > minX && cx1 < maxX)))
50
        {
51
            totalDamage += 50; // Hit in the border
52
        }
53
        if (((cx2 == minX || cx2 == maxX) && (cy2 > minY && cy2 < maxY)) ||
54
            ((cy2 == minY || cy2 == maxY) && (cx2 > minX && cx2 < maxX)))
55
        {
56
            totalDamage += 50; // Hit in the border
57
        }
58
        if (((cx3 == minX || cx3 == maxX) && (cy3 > minY && cy3 < maxY)) ||
59
            ((cy3 == minY || cy3 == maxY) && (cx3 > minX && cx3 < maxX)))
60
        {
61
            totalDamage += 50; // Hit in the border
62
        }
63
 
64
        // Check the internal body damage
65
        if ((cx1 > minX) && (cx1 < maxX) && (cy1 > minY) && (cy1 < maxY))
66
        {
67
            totalDamage += 100; // Hit in the internal body
68
        }
69
        if ((cx2 > minX) && (cx2 < maxX) && (cy2 > minY) && (cy2 < maxY))
70
        {
71
            totalDamage += 100; // Hit in the internal body
72
        }
73
        if ((cx3 > minX) && (cx3 < maxX) && (cy3 > minY) && (cy3 < maxY))
74
        {
75
            totalDamage += 100; // Hit in the internal body
76
        }
77
 
78
        Console.WriteLine(totalDamage + "%");
79
    }
80
}

*/