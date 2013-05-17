using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._3DStars
{
    class EvilCubes
    {
        static string[] separators = new string[] {" "};
        static int width ;
        static int heigth;
        static int dept;

        static void Main()
        {
            // width, heigth, dept => dimentions
            //[w,h,d] == 
            //[w-1, h,d] =
            //[w,h-1,d ] =
            //[w,h+1,d ] =
            //[w+1, h,d] =
            //[w,h,d-1 ] =
            //[w,h, d+1]



            //input data
            //first read cols - most outside loop - most turns - most outside part of the cube
            //next depth
            //next rows

            
            Inputcube();
            
            
            //we need three loops for a cude search
            //
            //
            //
            //
            //
            //
            //
            //
            //



            // [r,c]  == [r-1, c] == [r,c-1] == [r, c+ 1] == [r+1, c]



        }

        private static void Inputcube()
        {
            string[] dimentions = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            width = int.Parse(dimentions[0]);
            heigth = int.Parse(dimentions[1]);
            dept = int.Parse(dimentions[2]);

            char[, ,] cube = new char[width, heigth, dept];

            //read all input lines
            string[] deptRowsByHeigth = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);


            for (int currentHeigth = 0; currentHeigth < heigth; currentHeigth++)
            {
                string[] rows = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries); ;
                for (int currentDept = 0; currentDept < dept; currentDept++)
                {
                    string curRow = rows[currentDept];
                    for (int currentWidth = 0; currentWidth < width; currentWidth++)
                    {
                        cube[currentWidth, currentHeigth, currentDept] = curRow[currentWidth];
                    }
                }
            }
        }
    }
}
