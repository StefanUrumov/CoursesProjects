using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace PingPongGame
{
    class PingPong
    {
           static int firstPlayerPadSize = 4;
           static int secondPlayerPadSize = 4;
           static int ballPositionX = 0;
           static int ballPositionY = 0;
           static int firstPlayerPosition = 0;
           static int secondPlayerPosition = 0;

            static void RemoveScrollBars()
            {                
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            }

            static void DrawFIrstPlayer()
            {
                for (int y = firstPlayerPosition; y < firstPlayerPadSize - 1; y++ )
                {
                    PrintAtPosition(x, y, 'I');
                }

            }

        static void PrintAtPosition(int x, int y, char'I')
            {
             Console.SetCursorPosition(x, y);
             PrintPosition(1, y, "I");
            }

        static  void DrawSecondPlayer()
            {
                for (int y = )
                {
                    PrintAtPosition();
                }
            }







            static void DrawSecondPlayer()
            {

            }

        static void Main()
        {

            RemoveScrollBars();


            while(true)
            {
                DrawFIrstPlayer();
                DrawSecondPlayer();




                // Move first player
                // Move second player
                // Move the ball
                // Redraw all
                // - clear all
                // - draw first player
                // - draw second player
                // - draw ball
                // - print result
                 Thread.Sleep(60);
            }




        }
    }
}
