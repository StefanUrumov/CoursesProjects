using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MissCat2011
{
    class CatContest
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int cat0 = 0;
            int cat1 = 0;
            int cat2 = 0;
            int cat3 = 0;
            int cat4 = 0;
            int cat5 = 0;
            int cat6 = 0;
            int cat7 = 0;
            int cat8 = 0;
            int cat9 = 0;
            int cat10 = 0;
            



            for (int i = 1; i <= N; i++)
            {
                byte vote = byte.Parse(Console.ReadLine());

                if (vote == 1)
                {
                    cat1++;
                }
                if (vote == 2)
                {
                    cat2++;
                }
                if (vote == 3)
                {
                    cat3++;
                }
                if (vote == 4)
                {
                    cat4++;
                }
                if (vote == 5)
                {
                    cat5++;
                }
                if (vote == 6)
                {
                    cat6++;
                }
                if (vote == 7)
                {
                    cat7++;
                }
                if (vote == 8)
                {
                    cat8++;
                }
                if (vote == 9)
                {
                    cat9++;
                }
                if (vote == 10)
                {
                    cat10++;
                }                
            }

           int[] catsArr = new int[] { cat0, cat1, cat2, cat3, cat4, cat5, cat6, cat7, cat8, cat9, cat10};

           int maxIndex = 0;
           int bestCat = catsArr[0];
           for (int i = 1; i < catsArr.Length; i++)
           {
               //Console.WriteLine(catsArr[i]);
               if (bestCat < catsArr[i])
               {
                  int someCat = bestCat;
                  bestCat = catsArr[i];
                  catsArr[i] = bestCat;
                  maxIndex = i;
               }               
           }
           Console.WriteLine(maxIndex);
           
          
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           










        }
    }
}
