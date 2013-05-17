using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GreedyMidgets
{
    class GreedIsGood
    {
        static int coins;

        static void Main()
        {
            string valley = Console.ReadLine();
            
            string[] valleyMap = valley.Split(',');
            List<int> valleySteps = new List<int>();

            foreach (var item in valleyMap)
            {
                //Console.WriteLine(item);
                valleySteps.Add(int.Parse(item));
            }

            int patterns = int.Parse(Console.ReadLine());
                        
            string patternMap = string.Empty;
            
            for (int i = 0; i < patterns; i++)
            {
                patternMap += Console.ReadLine();
                if (i < patterns - 1)
                {
                    patternMap += '*';  
                }                
            }
                        
            //Console.WriteLine(pattMap);
                        
            int bestSum = 0;            
            var dwarf = 0;

            string[] allPatterns = patternMap.Split('*');
                        
            foreach (var pattern in allPatterns)
            {
               //Console.WriteLine(pattern);
               List<int> states = new List<int>();

               string[] currLine = pattern.Split(',');

               foreach (var num in currLine)
               {
                   //Console.WriteLine(num);
                   states.Add(int.Parse(num));
               }

               GetCoins(valleySteps,states, dwarf); //search valley by current pattern
               
               //find best found sum of collected coins
               if (coins > bestSum)
               {
                   bestSum = coins;
                   coins = 0; //must reset the coins for the next pattern map
               }

            }
                       
            Console.WriteLine(bestSum);
        }

        private static int GetCoins(List<int> valleySteps, List<int> states, int dwarf)
        {
            List<int> visited = new List<int>();

            dwarf = 0; //dwarf at the valley start index [0]
            coins += valleySteps[0];
            

            for (int i = 0, p = 0; i < valleySteps.Count && p < states.Count; i++, p++) //search in valley and current pattern
            {
                //if pattern is empty/used - start from the begging/top
                if (p == states.Count - 1)
                {

                    //find visited positions
                    visited.Add(dwarf);

                    //set dwarf - moves by i/valleySteps
                    dwarf += states[p]; //dwarf at the valley start index [0] + next step p/states

                    try
                    {
                        // break when dwarf steps on visited position - must remember previous steps(can use p/states)  
                        foreach (var steps in visited)
                        {
                            if (dwarf == steps)
                            {
                                return coins;
                            }
                        }

                        //collects coins valleySteps[i] using p/states as i (or in other words - dwarf itself)
                        coins += valleySteps[dwarf];
                    }
                    //breake when dwarf out of rangge
                    catch (ArgumentOutOfRangeException)
                    {
                        return coins;
                    }

                    p = - 1;   //because must be 0 (states[p] = 0), but p++ in for loop condition change it                
                    
                }
                else
                {
                    
                    //find visited positions
                    visited.Add(dwarf);

                    //set dwarf - moves by i/valleySteps
                    dwarf += states[p]; //dwarf at the valley start index [0] + next step p/states

                    try
                    {
                        // break when dwarf steps on visited position - must remember previous steps(can use p/states)  
                        foreach (var steps in visited)
                        {
                            if (dwarf == steps)
                            {
                                return coins;
                            }
                        }

                        //collects coins valleySteps[i] using p/states as i (or in other words - dwarf itself)
                        coins += valleySteps[dwarf];
                    }
                    //breake when dwarf out of rangge
                    catch (ArgumentOutOfRangeException)
                    {
                        return coins;
                    }
                }    
           }

            return coins;
            
        }
    }
}
