using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StandardDeckOfCards
{
    class DeckCards
    {
         static byte color;
         static byte cards;
        static void Main()
        {
            Console.WriteLine("All possible cards from a standard deck of 52 cards (without jokers): ");

            for (color = 1; color <= 4; color++)
            {
                 //Console.WriteLine(color + "*");
                 switch (color)
                 {
                     case 1:
                         Console.WriteLine("Spades:");break;
                     case 2:
                         Console.WriteLine("Hearts:"); break;
                     case 3:
                         Console.WriteLine("Diamonds:"); break;
                     case 4:
                         Console.WriteLine("Clubs:"); break;
                     default:
                         break;
                 }
                 for (cards = 1; cards <= 13; cards++)
                    {
                        //Console.WriteLine(cards);
                        switch (cards)
                        {
                            case 1:
                                Console.WriteLine("Two"); break;
                            case 2:
                                Console.WriteLine("Three"); break;
                            case 3:
                                Console.WriteLine("Four"); break;
                            case 4:
                                Console.WriteLine("Five"); break;
                            case 5:
                                Console.WriteLine("Six"); break;
                            case 6:
                                Console.WriteLine("Seven"); break;
                            case 7:
                                Console.WriteLine("Eight"); break;
                            case 8:
                                Console.WriteLine("Nine"); break;
                            case 9:
                                Console.WriteLine("Ten"); break;
                            case 10:
                                Console.WriteLine("Jack"); break;
                            case 11:
                                Console.WriteLine("Queen"); break;
                            case 12:
                                Console.WriteLine("King"); break;
                            case 13:
                                Console.WriteLine("Ace"); break;

                            default:
                                break;
                        }                        
                 }
                 Console.WriteLine();
            }
            
           





        }
    }
}
