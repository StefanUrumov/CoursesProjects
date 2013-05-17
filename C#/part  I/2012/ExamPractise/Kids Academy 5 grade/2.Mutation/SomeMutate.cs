using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Mutation
{
    class SomeMutate
    {
        static long microOrganism = 0 ;
        static long mutantOrganisms = 0;
        static byte counter;


        static void Main()
        {
            Console.WriteLine("Enter the number of microorganisms (1..1000): ");
            short microNum = short.Parse(Console.ReadLine()); //need for check logic

            Console.WriteLine("Enter microorganisms codes usibg space (m m1 m2)");
            string microCodes = Console.ReadLine();

            string [] Codes = microCodes.Split(' ');
            string mutantStr = " ";

            foreach (var micro in Codes)
	        {
                //Console.WriteLine(micro);
                for (int index = 0; index < micro.Length; index++)
                {
                    //Console.WriteLine(index);
                    byte singleCodeDigit = byte.Parse(micro[index].ToString());
                    //Console.WriteLine(singleCodeDigit);
                                        
                    if (singleCodeDigit % 2 == 0) //check if even
                    {
                        if (singleCodeDigit == 0)
                        {
                            singleCodeDigit = 9;
                        }
                        else
                        {
                            singleCodeDigit -= 1;
                        }                        
                    }                    
                    else //if (singleCodeDigit % 2 != 0)
                    {  
                        if (singleCodeDigit == 9)
                         {
                             singleCodeDigit = 0;
                         }
                        else
                        {
                            singleCodeDigit += 1;  
                        }                                              
                    }                    
                    //Console.WriteLine(singleCodeDigit);
                    mutantStr += singleCodeDigit.ToString();
                }
                    mutantStr += " ";
                    //Console.WriteLine(mutantStr);
	        }
            Console.WriteLine();

            string[] mutantsSplit = mutantStr.Split(' ');

            foreach (var mutant in mutantsSplit) //get mutated microorganisms
            {
                //Console.Write(mutant + " ");
                
                mutantOrganisms = long.Parse(mutant);
                Console.WriteLine(mutantOrganisms);
            }
            
            Console.WriteLine();
            foreach (var item in Codes) //get each microorganism as number
                {
                    //Console.Write(item + " ");
                    microOrganism = long.Parse(item);
                    Console.Write(microOrganism + " ");

                }

            Console.WriteLine();

            

            for (int index = 1; index <= microNum; index++)
            {
                GCD(microOrganism, mutantOrganisms);
            }
            Console.WriteLine(counter);

        }

        public static long GCD(long microOrganism, long mutantOrganism)
        {
            while (mutantOrganism != 0)
            {
                long tmp = mutantOrganism;
                mutantOrganism = microOrganism % mutantOrganism;
                microOrganism = tmp;
            }
            Console.WriteLine(microOrganism);
            if (microOrganism < 10)
            {
                counter++;
            }
            return microOrganism;
        }
    }
}
