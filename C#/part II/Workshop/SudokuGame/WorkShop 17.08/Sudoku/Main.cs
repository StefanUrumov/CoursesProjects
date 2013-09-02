using System;

namespace Sudoku
{
    //Main entry point fo the game
    class MainEntry
    {
        static void Main()
        {
            //Init game window and
            GameWindow gameWindow = new GameWindow();
            gameWindow.StartMainLoop();
        }
    }
}
