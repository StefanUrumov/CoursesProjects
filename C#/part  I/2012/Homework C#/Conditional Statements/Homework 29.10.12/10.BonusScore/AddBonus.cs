using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BonusScore
{
    class AddBonus
    {
        static void Main()
        {
            Console.WriteLine("Enter your points in range [1-9] and receive bonus: ");
            int userPoints = int.Parse(Console.ReadLine());

           try
           {
                switch (userPoints)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("Your points now are: {0}", (userPoints * 10) + userPoints); break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("Your points now are: {0}", (userPoints * 100) + userPoints); break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("Your points now are: {0}", (userPoints * 1000) + userPoints); break;
                    case 0:
                    default:
                        //Console.WriteLine("Error report! Invalid input!");
                        throw new Exception("You've entered an invalid number!");                        
                        break;
                        
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("An error has been found: {0}!", ex.Message);
                Console.WriteLine("Stack: {0}", ex.StackTrace);
                Console.WriteLine("Target site: {0}", ex.TargetSite);
                Console.WriteLine("Source: {0}", ex.Source);
            
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has been found: {0}!", e.Message);
                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Target site: {0}", e.TargetSite);
                Console.WriteLine("Source: {0}", e.Source);
            }
        }
    }
}

