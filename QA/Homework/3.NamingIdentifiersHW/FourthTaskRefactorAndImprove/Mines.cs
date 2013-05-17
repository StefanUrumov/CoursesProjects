using System;
using System.Collections.Generic;
using System.Linq;

namespace FourthTaskRefactorAndImprove
{
	public class Mines
	{	
		static void Main()
		{
			string playerCommand = string.Empty;
			char[,] gameField = CreateGameFiled();
			char[,] mineBombs = SetMineBombs();
			int count = 0;
			bool isMineExplode = false;
			List<Points> hallOfFame = new List<Points>(6);
			int row = 0;
			int column = 0;
			bool flag = true;
			const int maximum = 35;
			bool flag2 = false;

			do
			{
				if (flag)
				{
					Console.WriteLine("Let's play “MineSweapers”. Try your luck and find fields without mine bombs." +
					" Using 'top' command you can see top results, 'restart' new game, 'exit' closes the game!");
					PlaceMineBombs(gameField);
					flag = false;
				}

				Console.Write("Input row and column: ");
				playerCommand = Console.ReadLine().Trim();

				if (playerCommand.Length >= 3)
				{
					if (int.TryParse(playerCommand[0].ToString(), out row) &&
					int.TryParse(playerCommand[2].ToString(), out column) &&
						row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
					{
						playerCommand = "turn";
					}
				}
				switch (playerCommand)
				{
					case "top":
						PlayerRating(hallOfFame);
						break;
					case "restart":
						gameField = CreateGameFiled();
						mineBombs = SetMineBombs();
						PlaceMineBombs(gameField);
						isMineExplode = false;
						flag = false;
						break;
					case "exit":
						Console.WriteLine("Bye, Bye, Bye!");
						break;
					case "turn":
						if (mineBombs[row, column] != '*')
						{
							if (mineBombs[row, column] == '-')
							{
								YourTurn(gameField, mineBombs, row, column);
								count++;
							}
							if (maximum == count)
							{
								flag2 = true;
							}
							else
							{
								PlaceMineBombs(gameField);
							}
						}
						else
						{
							isMineExplode = true;
						}
						break;
					default:
						Console.WriteLine("Error! Invalid Command!");
						break;
				}
				if (isMineExplode)
				{
					PlaceMineBombs(mineBombs);
					Console.Write("\n Hrrrrrr! You died like hero with {0} points. " +
						"Enter your name: ", count);
					string playerGameNickName = Console.ReadLine();
					Points playerScore = new Points(playerGameNickName, count);
					if (hallOfFame.Count < 5)
					{
						hallOfFame.Add(playerScore);
					}
					else
					{
						for (int i = 0; i < hallOfFame.Count; i++)
						{
                            if (
                            hallOfFame[i].PlayerPoints < playerScore.PlayerPoints)
							{
								hallOfFame.Insert(i, playerScore);
								hallOfFame.RemoveAt(hallOfFame.Count - 1);
								break;
							}
						}
					}
					hallOfFame.Sort((Points r1, Points r2) => r2.PlayerName.CompareTo(r1.PlayerName));
                    hallOfFame.Sort((Points r1, Points r2) => r2.PlayerPoints.CompareTo(r1.PlayerPoints));
					PlayerRating(hallOfFame);

					gameField = CreateGameFiled();
					mineBombs = SetMineBombs();
					count = 0;
					isMineExplode = false;
					flag = true;
				}
				if (flag2)
				{
					Console.WriteLine("\n Very good! You have opened 35 cells without a drop of blood.");
					PlaceMineBombs(mineBombs);
					Console.WriteLine("Insert your name: ");
					string playerPerfectGame = Console.ReadLine();
					Points playerPointsEarned = new Points(playerPerfectGame, count);
					hallOfFame.Add(playerPointsEarned);
					PlayerRating(hallOfFame);
					gameField = CreateGameFiled();
					mineBombs = SetMineBombs();
					count = 0;
					flag2 = false;
					flag = true;
				}
			}
			while (playerCommand != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("Goodbye.");
			Console.Read();
		}

		private static void PlayerRating(List<Points> playerPointsScore)
		{
			Console.WriteLine("\n Points:");
			if (playerPointsScore.Count > 0)
			{
				for (int i = 0; i < playerPointsScore.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} cells",
						i + 1, playerPointsScore[i].PlayerName, playerPointsScore[i].PlayerPoints);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty rating!\n");
			}
		}

		private static void YourTurn(char[,] mineField, char[,] bombMines, int fieldRow, int fieldColumn)
		{
			char minesCount = HowManyMineBombs(bombMines, fieldRow, fieldColumn);
			bombMines[fieldRow, fieldColumn] = minesCount;
			mineField[fieldRow, fieldColumn] = minesCount;
		}

		private static void PlaceMineBombs(char[,] board)
		{
			int mineFieldRow = board.GetLength(0);
			int mineFieldColumns = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < mineFieldRow; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < mineFieldColumns; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameFiled()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] SetMineBombs()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] gameBoard = new char[boardRows, boardColumns];

			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					gameBoard[i, j] = '-';
				}
			}

			List<int> boardMines = new List<int>();
			while (boardMines.Count < 15)
			{
				Random random = new Random();
				int randomMine = random.Next(50);
				if (!boardMines.Contains(randomMine))
				{
					boardMines.Add(randomMine);
				}
			}

			foreach (int cell in boardMines)
			{
				int columnInBoard = (cell / boardColumns);
				int rowInBoard = (cell % boardColumns);
				if (rowInBoard == 0 && cell != 0)
				{
					columnInBoard--;
					rowInBoard = boardColumns;
				}
				else
				{
					rowInBoard++;
				}
				gameBoard[columnInBoard, rowInBoard - 1] = '*';
			}

			return gameBoard;
		}

		private static void CalculateMines(char[,] pole)
		{
			int columnsInBoard = pole.GetLength(0);
			int rowsInBoard = pole.GetLength(1);

			for (int i = 0; i < columnsInBoard; i++)
			{
				for (int j = 0; j < rowsInBoard; j++)
				{
					if (pole[i, j] != '*')
					{
						char kolkoo = HowManyMineBombs(pole, i, j);
						pole[i, j] = kolkoo;
					}
				}
			}
		}

		private static char HowManyMineBombs(char[,] gameField, int rows, int columns)
		{
			int mineBombsCount = 0;
			int rowsInField = gameField.GetLength(0);
			int columnsInField = gameField.GetLength(1);

			if (rows - 1 >= 0)
			{
				if (gameField[rows - 1, columns] == '*')
				{ 
					mineBombsCount++; 
				}
			}
			if (rows + 1 < rowsInField)
			{
				if (gameField[rows + 1, columns] == '*')
				{ 
					mineBombsCount++; 
				}
			}
			if (columns - 1 >= 0)
			{
				if (gameField[rows, columns - 1] == '*')
				{ 
					mineBombsCount++;
				}
			}
			if (columns + 1 < columnsInField)
			{
				if (gameField[rows, columns + 1] == '*')
				{ 
					mineBombsCount++;
				}
			}
			if ((rows - 1 >= 0) && (columns - 1 >= 0))
			{
				if (gameField[rows - 1, columns - 1] == '*')
				{ 
					mineBombsCount++; 
				}
			}
			if ((rows - 1 >= 0) && (columns + 1 < columnsInField))
			{
				if (gameField[rows - 1, columns + 1] == '*')
				{ 
					mineBombsCount++; 
				}
			}
			if ((rows + 1 < rowsInField) && (columns - 1 >= 0))
			{
				if (gameField[rows + 1, columns - 1] == '*')
				{ 
					mineBombsCount++; 
				}
			}
			if ((rows + 1 < rowsInField) && (columns + 1 < columnsInField))
			{
				if (gameField[rows + 1, columns + 1] == '*')
				{ 
					mineBombsCount++; 
				}
			}
			return char.Parse(mineBombsCount.ToString());
		}
	}
}
