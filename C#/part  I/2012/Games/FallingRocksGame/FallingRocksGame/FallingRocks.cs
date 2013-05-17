using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FallingRocksGame
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

    class FallingRocks
    {
        static void Main()
        {
            byte right = 0; // the numbers are == index of the array directions
            byte left = 1;
            byte down = 0;
            int userPoints = 0;

     
            Position[] directions = new Position[]
            {
                new Position(0, 1),  // right == [1] array element
                new Position(0, -1), // left  == [2] array element
            };

            Position[] goldDirections = new Position[]
            {
                new Position(1, 0),  // down == [1] array element
                
            };

            Position[] rocksDirections = new Position[]
            {
                new Position(1, 0),  // down == [1] array element                
            };

            int direction = right; // current dwarf direction
            int goldDirection = down;
            int rocksDirection = down;

            Random randomNumbersGenerator = new Random();
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            //1.
            Queue<Position> dwarfBody = new Queue<Position>();
            for (int i = 0; i <= 1; i++)
            {
                dwarfBody.Enqueue(new Position(Console.WindowHeight - 2, i));
            }

            foreach (Position position in dwarfBody)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("0");
            }
            Queue<Position> goldBrick = new Queue<Position>();
            for (int i = 0; i < 1; i++)
            {
                goldBrick.Enqueue(new Position(0, randomNumbersGenerator.Next(0, Console.WindowWidth)));
            }

            foreach (Position position in goldBrick)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("$");
            }

            Queue<Position> goldBrick1 = new Queue<Position>();
            for (int i = 0; i < 1; i++)
            {
                goldBrick1.Enqueue(new Position(0, randomNumbersGenerator.Next(0, Console.WindowWidth)));
            }

            foreach (Position position1 in goldBrick1)
            {
                Console.SetCursorPosition(position1.col, position1.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("$");
            }

            Queue<Position> goldBrick2 = new Queue<Position>();
            for (int i = 0; i < 1; i++)
            {
                goldBrick2.Enqueue(new Position(0, randomNumbersGenerator.Next(0, Console.WindowWidth)));
            }

            foreach (Position position2 in goldBrick2)
            {
                Console.SetCursorPosition(position2.col, position2.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("$");
            }

            Queue<Position> rockBody = new Queue<Position>();
            for (int i = 0; i < 2; i++)
            {
                rockBody.Enqueue(new Position(0, randomNumbersGenerator.Next(0, Console.WindowWidth)));
            }

            foreach (Position position in rockBody)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+");
            }

            Queue<Position> rockBody1 = new Queue<Position>();
            for (int i = 0; i < 3; i++)
            {
                rockBody1.Enqueue(new Position(0, randomNumbersGenerator.Next(0, Console.WindowWidth)));
            }

            foreach (Position position1 in rockBody1)
            {
                Console.SetCursorPosition(position1.col, position1.row);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("#");
            }

            Queue<Position> rockBody2 = new Queue<Position>();
            for (int i = 0; i <= 2; i++)
            {
                rockBody2.Enqueue(new Position(0, randomNumbersGenerator.Next(0, Console.WindowWidth)));
            }

            foreach (Position position2 in rockBody2)
            {
                Console.SetCursorPosition(position2.col, position2.row);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("^");
            }

            Queue<Position> rockBody3 = new Queue<Position>();
            for (int i = 0; i <= 1; i++)
            {
                rockBody3.Enqueue(new Position(0, randomNumbersGenerator.Next(0, Console.WindowWidth)));
            }

            foreach (Position position3 in rockBody3)
            {
                Console.SetCursorPosition(position3.col, position3.row);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("%");
            }

            Queue<Position> rockBody4 = new Queue<Position>();
            for (int i = 0; i < 1; i++)
            {
                rockBody4.Enqueue(new Position(0, randomNumbersGenerator.Next(0, Console.WindowWidth)));
            }

            foreach (Position position4 in rockBody4)
            {
                Console.SetCursorPosition(position4.col, position4.row);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("&");
            }

            // loop
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();

                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        direction = left; // first element of our array - directions
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        direction = right;
                    }
                }

                goldDirection = down;
                rocksDirection = down;

                //2.
                Position dwarfHead = dwarfBody.Last(); // old dwarf head
                Position nextDirection = directions[direction];
                Position dwarfNewHead = new Position(dwarfHead.row + nextDirection.row,
                    dwarfHead.col + nextDirection.col);

                Position goldEnd = goldBrick.Last(); // old glod end
                Position goldNextDirection = goldDirections[goldDirection];
                Position goldNewEnd = new Position(goldEnd.row + goldNextDirection.row,
                    goldEnd.col + goldNextDirection.col);

                Position goldEnd2 = goldBrick2.Last(); // old glod end
                Position goldNextDirection2 = goldDirections[goldDirection];
                Position goldNewEnd2 = new Position(goldEnd2.row + goldNextDirection2.row,
                    goldEnd2.col + goldNextDirection2.col);

                Position goldEnd1 = goldBrick1.Last(); // old gold end
                Position goldNextDirection1 = goldDirections[goldDirection];
                Position goldNewEnd1 = new Position(goldEnd1.row + goldNextDirection1.row,
                    goldEnd1.col + goldNextDirection1.col);

                Position rocksEnd = rockBody.Last(); // old rock end
                Position rocksNextDirection = rocksDirections[rocksDirection];
                Position rocksNewEnd = new Position(rocksEnd.row + rocksNextDirection.row,
                    rocksEnd.col + rocksNextDirection.col);

                Position rocksEnd1 = rockBody1.Last();
                Position rocksNextDirection1 = rocksDirections[rocksDirection];
                Position rocksNewEnd1 = new Position(rocksEnd1.row + rocksNextDirection1.row,
                    rocksEnd1.col + rocksNextDirection1.col);

                Position rocksEnd2 = rockBody2.Last();
                Position rocksNextDirection2 = rocksDirections[rocksDirection];
                Position rocksNewEnd2 = new Position(rocksEnd2.row + rocksNextDirection2.row,
                    rocksEnd2.col + rocksNextDirection2.col);

                Position rocksEnd3 = rockBody3.Last();
                Position rocksNextDirection3 = rocksDirections[rocksDirection];
                Position rocksNewEnd3 = new Position(rocksEnd3.row + rocksNextDirection3.row,
                    rocksEnd3.col + rocksNextDirection3.col);

                Position rocksEnd4 = rockBody4.Last();
                Position rocksNextDirection4 = rocksDirections[rocksDirection];
                Position rocksNewEnd4 = new Position(rocksEnd4.row + rocksNextDirection4.row,
                    rocksEnd4.col + rocksNextDirection4.col);


                //3. lets the dwarf pass the window's borders
                if (dwarfNewHead.col >= Console.WindowWidth)
                {
                    dwarfNewHead.row = Console.WindowHeight - 2; // bounce the dwarf backwards
                    dwarfNewHead.col = Console.WindowWidth - 1;
                    direction = left;
                }
                else if (dwarfNewHead.col <= Console.WindowWidth - Console.WindowWidth)
                {
                    dwarfNewHead.row = Console.WindowHeight - 2;
                    dwarfNewHead.col = 0;
                    direction = right;
                }

                if (goldNewEnd.row >= Console.WindowHeight)
                {
                    goldNewEnd.row = randomNumbersGenerator.Next(0, Console.WindowHeight / 10);  // lets the gold to pass 
                    goldNewEnd.col = randomNumbersGenerator.Next(0, Console.WindowWidth);  // the window borders
                        
                }
                if (goldNewEnd1.row >= Console.WindowHeight)
                {
                    goldNewEnd1.row = randomNumbersGenerator.Next(0, Console.WindowHeight / 10);
                    goldNewEnd1.col = randomNumbersGenerator.Next(0, Console.WindowWidth);
                }

                if (goldNewEnd2.row >= Console.WindowHeight)
                {
                    goldNewEnd2.row = randomNumbersGenerator.Next(0, Console.WindowHeight / 10);
                    goldNewEnd2.col = randomNumbersGenerator.Next(0, Console.WindowWidth);
                }

                if (rocksNewEnd.row >= Console.WindowHeight)
                {
                    rocksNewEnd.row = randomNumbersGenerator.Next(0, Console.WindowHeight / 10);  // borders error top and left 
                    rocksNewEnd.col = randomNumbersGenerator.Next(0, Console.WindowWidth);    // if removed it bounce*    
                }
                if (rocksNewEnd1.row >= Console.WindowHeight)
                {
                    rocksNewEnd1.row = randomNumbersGenerator.Next(0, Console.WindowHeight / 10);                                                    // use random num to change position!
                    rocksNewEnd1.col = randomNumbersGenerator.Next(0, Console.WindowWidth);   //if used buffer width, should generate different row 
                }
                if (rocksNewEnd2.row >= Console.WindowHeight)
                {
                    rocksNewEnd2.row = randomNumbersGenerator.Next(0, Console.WindowHeight / 10);
                    rocksNewEnd2.col = randomNumbersGenerator.Next(0, Console.WindowWidth);
                }
                if (rocksNewEnd3.row >= Console.WindowHeight)
                {
                    rocksNewEnd3.row = randomNumbersGenerator.Next(0, Console.WindowHeight / 10);
                    rocksNewEnd3.col = randomNumbersGenerator.Next(0, Console.WindowWidth);
                }
                if (rocksNewEnd4.row >= Console.WindowHeight)
                {
                    rocksNewEnd4.row = randomNumbersGenerator.Next(0, Console.WindowHeight / 10);
                    rocksNewEnd4.col = randomNumbersGenerator.Next(0, Console.WindowWidth);
                }

                
                //4.
                Console.SetCursorPosition(dwarfHead.col, dwarfHead.row);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("0");

                Console.SetCursorPosition(goldEnd.col, goldEnd.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("$");

                Console.SetCursorPosition(goldEnd1.col, goldEnd1.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("$");

                Console.SetCursorPosition(goldEnd2.col, goldEnd2.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("$");

                Console.SetCursorPosition(rocksEnd.col, rocksEnd.row);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+");

                Console.SetCursorPosition(rocksEnd1.col, rocksEnd1.row);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("#");

                Console.SetCursorPosition(rocksEnd2.col, rocksEnd2.row);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("^");

                Console.SetCursorPosition(rocksEnd3.col, rocksEnd3.row);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("%");

                Console.SetCursorPosition(rocksEnd4.col, rocksEnd4.row);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("&");

                //5.
                dwarfBody.Enqueue(dwarfNewHead);
                Console.SetCursorPosition(dwarfNewHead.col, dwarfNewHead.row);
                Console.ForegroundColor = ConsoleColor.Red;
                if (direction == right) Console.Write(">"); //the head of the dwarf  
                if (direction == left) Console.Write("<");

                goldBrick.Enqueue(goldNewEnd);
                Console.SetCursorPosition(goldNewEnd.col, goldNewEnd.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (goldDirection == down) Console.Write("$"); //the head of the snake 

                goldBrick1.Enqueue(goldNewEnd1);
                Console.SetCursorPosition(goldNewEnd1.col, goldNewEnd1.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (goldDirection == down) Console.Write("$"); //the head of the snake 

                goldBrick2.Enqueue(goldNewEnd2);
                Console.SetCursorPosition(goldNewEnd2.col, goldNewEnd2.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (goldDirection == down) Console.Write("$"); //the head of the snake 

                rockBody.Enqueue(rocksNewEnd);
                Console.SetCursorPosition(rocksNewEnd.col, rocksNewEnd.row);
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (rocksDirection == down) Console.Write("+"); //the head of the rock 

                rockBody1.Enqueue(rocksNewEnd1);
                Console.SetCursorPosition(rocksNewEnd1.col, rocksNewEnd1.row);
                Console.ForegroundColor = ConsoleColor.Magenta;
                if (rocksDirection == down) Console.Write("#");

                rockBody2.Enqueue(rocksNewEnd2);
                Console.SetCursorPosition(rocksNewEnd2.col, rocksNewEnd2.row);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (rocksDirection == down) Console.Write("^");

                rockBody3.Enqueue(rocksNewEnd3);
                Console.SetCursorPosition(rocksNewEnd3.col, rocksNewEnd3.row);
                Console.ForegroundColor = ConsoleColor.Blue;
                if (rocksDirection == down) Console.Write("%");

                rockBody4.Enqueue(rocksNewEnd4);
                Console.SetCursorPosition(rocksNewEnd4.col, rocksNewEnd4.row);
                Console.ForegroundColor = ConsoleColor.Red;
                if (rocksDirection == down) Console.Write("&");


                //6. moving...
                Position last = dwarfBody.Dequeue();
                Console.SetCursorPosition(last.col, last.row);
                Console.Write(" ");

                Position goldlast = goldBrick.Dequeue();
                Console.SetCursorPosition(goldlast.col, goldlast.row);
                Console.Write(" ");

                Position goldlast1 = goldBrick1.Dequeue();
                Console.SetCursorPosition(goldlast1.col, goldlast1.row);
                Console.Write(" ");

                Position goldlast2 = goldBrick2.Dequeue();
                Console.SetCursorPosition(goldlast2.col, goldlast2.row);
                Console.Write(" ");

                Position rockLast = rockBody.Dequeue();
                Console.SetCursorPosition(rockLast.col, rockLast.row);
                Console.Write(" ");

                Position rockLast1 = rockBody1.Dequeue();
                Console.SetCursorPosition(rockLast1.col, rockLast1.row);
                Console.Write(" ");

                Position rockLast2 = rockBody2.Dequeue();
                Console.SetCursorPosition(rockLast2.col, rockLast2.row);
                Console.Write(" ");

                Position rockLast3 = rockBody3.Dequeue();
                Console.SetCursorPosition(rockLast3.col, rockLast3.row);
                Console.Write(" ");

                Position rockLast4 = rockBody4.Dequeue();
                Console.SetCursorPosition(rockLast4.col, rockLast4.row);
                Console.Write(" ");


                //missing logic to calculate the score
                //use snake logic queue.contains

                if (dwarfBody.Contains(goldNewEnd) || dwarfBody.Contains(goldNewEnd1) || dwarfBody.Contains(goldNewEnd2))
                {
                    userPoints++;
                }
                if (dwarfBody.Contains(rocksNewEnd) || dwarfBody.Contains(rocksNewEnd1) || dwarfBody.Contains(rocksNewEnd2) || dwarfBody.Contains(rocksNewEnd3) || dwarfBody.Contains(rocksNewEnd4))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game over!");
                    Console.WriteLine("Your points are: {0}", userPoints * 50);
                    return;
                }
                                
                
                Thread.Sleep(150);
                Console.Clear();                
            }

        }
        

    }
}
