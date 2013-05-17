﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeGame
{
    struct Position
    {
        public int row;
        public int col;

        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    class SnakeGame
    {
        static void Main()
        {
            byte right = 0; // the numbers are == index of the array directions
            byte left = 1;
            byte down = 2;
            byte up = 3;
            int lastFoodTime = 0;
            int foodDissapearTime = 7000;
            int negativePoints = 0;


            // Environment.TickCount
            // DateTime.Now can be used also
            Position[] directions = new Position[]
            {
                new Position(0, 1),  // right == [1] array element
                new Position(0, -1), // left  == [2] array element
                new Position(1, 0),  // down  == [3] array element
                new Position(-1, 0), // up    == [4] array element
            };
            double sleepTime = 100;

            int direction = right; // current snake direction
            Random randomNumbersGenerator = new Random();
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;            
            lastFoodTime = Environment.TickCount;

            List<Position> obstacles = new List<Position>() //creating obstacles
            {
                new Position(12, 12),
                new Position(14, 20),
                new Position(5, 20),                
            };

            foreach (Position obstacle in obstacles) // print them
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(obstacle.col, obstacle.row);
                Console.Write("=");
            }

            Queue<Position> snakeElements = new Queue<Position>();            
            for (int i= 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }

            Position food;

            do
            {
                food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                randomNumbersGenerator.Next(0, Console.WindowWidth));
            }
            while(snakeElements.Contains(food) || obstacles.Contains(food));
            
            Console.SetCursorPosition(food.col, food.row);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("@");
            

            foreach (Position position in snakeElements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("*");
            }

            while (true)
            {
                negativePoints++;

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();

                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                       if(direction != right) direction = left; // first elemnent of our array - directions
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        if (direction != left) direction = right; // using if, we are stoppping the snake to 
                    }                                             // pass through itself
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        if (direction != down) direction = up;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        if (direction != up) direction = down ;
                    }
                }

                Position snakeHead = snakeElements.Last(); // old snake head
                Position nextDirection = directions[direction];
                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row,
                    snakeHead.col + nextDirection.col);

                if (snakeNewHead.col < 0) snakeHead.col = Console.WindowWidth - 1;   // lets the snake
                if (snakeNewHead.row < 0) snakeHead.row = Console.WindowHeight - 1;  // pass the window's
                if (snakeNewHead.row >= Console.WindowHeight) snakeNewHead.row = 0;  // borders
                if (snakeNewHead.col >= Console.WindowWidth) snakeNewHead.col = 0;    // error top and left    
                                                                                       
                
                if (snakeElements.Contains(snakeNewHead) || obstacles.Contains(snakeNewHead))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game over!");
                    int userPoints = (snakeElements.Count - 6) * 100 - negativePoints;
                    if (userPoints < 0) userPoints = 0;
                    Console.WriteLine("Your points are: {0}", userPoints);
                    return;
                }

                Console.SetCursorPosition(snakeHead.col, snakeHead.row);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("*");

                snakeElements.Enqueue(snakeNewHead);
                Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
                Console.ForegroundColor = ConsoleColor.Gray;
                if (direction == right) Console.Write(">"); //the head of the snake 
                if (direction == left) Console.Write("<");
                if (direction == up) Console.Write("^");
                if (direction == down) Console.Write("v");



                if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                {
                    // feeding the snake - generate apple
                    do
                    {                    
                        food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                            randomNumbersGenerator.Next(0, Console.WindowWidth));
                    }
                    while(snakeElements.Contains(food) || obstacles.Contains(food)); // check if food  
                    lastFoodTime = Environment.TickCount;                            // and obstacles
                    Console.SetCursorPosition(food.col, food.row);                   // are drawn over
                    Console.ForegroundColor = ConsoleColor.Yellow;                   // the snake's body
                    Console.Write("@");
                    sleepTime--;   
             
                    Position obstacle = new Position();
                        do
                        {
                            obstacle = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                            randomNumbersGenerator.Next(0, Console.WindowWidth));                    
                        }
                        while(snakeElements.Contains(obstacle) ||
                            obstacles.Contains(obstacle) ||
                            (food.col != obstacle.col && food.row != obstacle.row));
                    obstacles.Add(obstacle);
                    Console.SetCursorPosition(obstacle.col, obstacle.row);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("=");
                }
                else
                {
                    // moving...
                    Position last = snakeElements.Dequeue();
                    Console.SetCursorPosition(last.col, last.row);
                    Console.Write(" ");
                }
                             

                if (Environment.TickCount - lastFoodTime >= foodDissapearTime)
                {
                    negativePoints = negativePoints + 50;
                    Console.SetCursorPosition(food.col, food.row);
                    Console.Write(" ");

                     do
                    {                    
                        food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                            randomNumbersGenerator.Next(0, Console.WindowWidth));
                    }
                     while (snakeElements.Contains(food) || obstacles.Contains(food)); 
                    lastFoodTime = Environment.TickCount;
                }


                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@"); // code always providing 'apple' 

                sleepTime -= 0.01;
                Thread.Sleep((int)sleepTime);                 
            }
            
        }
    }
}
