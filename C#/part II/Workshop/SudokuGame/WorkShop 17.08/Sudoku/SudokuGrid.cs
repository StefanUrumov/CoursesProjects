using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace Sudoku
{
    class SudokuGrid
    {
        public const int SudokuDimension = 9;
        private const int SudokuGroupDimension = 3;
        public const int EmptyCellValue = 0;

        private static readonly Random randGenerator = new Random();
        private readonly int[,] numbers;
        private readonly bool[,] editableFlags;

        public readonly Difficulty GameDifficulty;

        private int emptyCellsCount;

        public void SaveGame()
        {
            using (StreamWriter save = new StreamWriter("SavedGame.txt", false))
            {
                for (int group = 0; group < SudokuGroupDimension; group++)
                {
                    for (int row = group * SudokuGroupDimension; row < SudokuGroupDimension * (group + 1); row++)
                    {
                        save.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}",
                            numbers[row, 0], numbers[row, 1], numbers[row, 2],
                            numbers[row, 3], numbers[row, 4], numbers[row, 5],
                            numbers[row, 6], numbers[row, 7], numbers[row, 8]);
                    }
                }
            }
        }

        public void LoadGame()
        {
            string text = "";
            int[,] loadedGame = new int[9, 9];
            using (StreamReader read = new StreamReader("SavedGame.txt"))
                text = read.ReadToEnd();
            string[] splitedText = text.Split('\n');
            for (int row = 0; row < 9; row++)
            {
                string[] values = splitedText[row].Split(' ');
                for (int col = 0; col < 9; col++)
                {
                    loadedGame[row, col] = int.Parse(values[col]);
                }

            }
 
        }
        
        public int EmptyCells
        {
            get { return emptyCellsCount; }
            set { emptyCellsCount = value; }
        }
        
        public SudokuGrid()
        {
            numbers = new int[9, 9];
            editableFlags = new bool[9, 9];
        }

        public SudokuGrid(int[,] numbers,Difficulty gameDifficulty, bool isEditable)
        {
            GameDifficulty = gameDifficulty;
            this.numbers = new int[numbers.GetLength(0), numbers.GetLength(1)];
            Array.Copy(numbers, this.numbers, numbers.Length);
            if (isEditable)
            {
                editableFlags = new bool[9, 9];
                MakeEditable();
            }
            else
            {
                editableFlags = new bool[9, 9];
            }
        }

        //Indexer for the grid's elements
        public int this[int row, int col]
        {
            get { return numbers[row, col]; }
            set { numbers[row, col] = value; }
        }

        public bool WriteNumber(int row, int col, int newValue)
        {
            //Check if cell is editable
            if (editableFlags[row, col])
            {
                numbers[row, col] = newValue;
                EmptyCells = GetEmptyCellCount();
                return true;
            }
            else return false;
        }

        public int GetEmptyCellCount()
        {
            int emptyCellsCount = 0;

            for (int row = 0; row < SudokuDimension; row++)
            {
                for (int col = 0; col < SudokuDimension; col++)
                {
                    if (numbers[row, col] == EmptyCellValue)
                        emptyCellsCount++;
                }
            }

            if (emptyCellsCount == 0)
            {
                CheckUserSolution(numbers);
            }

            return emptyCellsCount;
        }
  
        private void CheckUserSolution(int[,] numbers)
        {
            IList<int> currRow = new List<int>();
            IList<int> currCol = new List<int>();
            IList<int> subBox = new List<int>();
            
            //check horizontal
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    currRow.Add(numbers[row, col]);
                }

                if (!IsRowCorrect(currRow))
                {
                    throw new SudokuException("The row is not correct!");
                    //custom sudoku exception
                }
                currRow = new List<int>();
            }

            //check vertical
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    currCol.Add(numbers[col, row]);
                }

                if (!IsColCorrect(currCol))
                {
                    throw new SudokuException("The col is not correct!");
                    //custom sudoku exception
                }
                currCol = new List<int>();
            }

            //check sudoku subbox
            int rows = numbers.GetLength(0);
            int cols = numbers.GetLength(1);

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    if ((row + 1) % 3 == 0 && (col + 1) % 3 == 0)
                    {
                        subBox.Add(numbers[row, col]);
                        subBox.Add(numbers[row, col - 1]);
                        subBox.Add(numbers[row, col - 2]);

                        subBox.Add(numbers[row - 1, col]);
                        subBox.Add(numbers[row - 1, col - 1]);
                        subBox.Add(numbers[row - 1, col - 2]);
                                   
                        subBox.Add(numbers[row - 2, col]);
                        subBox.Add(numbers[row - 2, col - 1]);
                        subBox.Add(numbers[row - 2, col - 2]);
                    }


                    if (!IsBoxCorrect(subBox) && subBox.Count == 9)
                    {
                        throw new ArgumentException("The subbox is not correct");
                        //custom sudoku exception
                    }
                    subBox = new List<int>();
                }
            }    
        }

        private static bool IsBoxCorrect(IList<int> subBox)
        {
            int boxNumberPresent = 0;

            for (int number = 0; number < subBox.Count; number++)
            {
                for (int numberInRow = 0; numberInRow < subBox.Count; numberInRow++)
                {
                    if (subBox[number] == subBox[numberInRow])
                    {
                        boxNumberPresent++;
                        if (boxNumberPresent > 1)
                        {
                            return false;
                        }
                    }
                }
                boxNumberPresent = 0;
            }
            return true;
        }

        private static bool IsColCorrect(IList<int> currCol)
        {
            int colNumberPresent = 0;

            for (int number = 0; number < currCol.Count; number++)
            {
                for (int numberInCol = 0; numberInCol < currCol.Count; numberInCol++)
                {
                    if (currCol[number] == currCol[numberInCol])
                    {
                        colNumberPresent++;
                        if (colNumberPresent > 1)
                        {
                            return false;
                        }
                    }
                }
                colNumberPresent = 0;
            }
            return true;

        }

        private static bool IsRowCorrect(IList<int> currRow)
        {
            int rowNumberPresent = 0;

            for (int number = 0; number < currRow.Count; number++)
            {
                for (int numberInRow = 0; numberInRow < currRow.Count; numberInRow++)
                {
                    if (currRow[number] == currRow[numberInRow])
                    {
                        rowNumberPresent++;
                        if (rowNumberPresent > 1)
                        {
                            return false;
                        }
                    }
                }
                rowNumberPresent = 0;
            }
            return true;
        }

        public void ClearCell(int row, int col)
        {
            numbers[row, col] = 0;
            editableFlags[row, col] = true;
        }

        public void ClearUserCells()
        {
            for (int row = 0; row < SudokuDimension; row++)
            {
                for (int col = 0; col < SudokuDimension; col++)
                {
                    WriteNumber(row,col,EmptyCellValue);
                }
            }
        }

        public void MakeEditable()
        {
            for (int row = 0; row < SudokuDimension; row++)
            {
                for (int col = 0; col < SudokuDimension; col++)
                {
                    editableFlags[row, col] = true;
                }
            }
        }

        public void Transform(TransformType type)
        {
            switch (type)
            {
                #region Swap Rows in the same group.
                case TransformType.SwapRows:
                    {
                        int sourceRow = randGenerator.Next(1, 3);
                        int sourceGroup = randGenerator.Next(0, 2);
                        int destinationRow = randGenerator.Next(-2, 2);
                        int newRowIndex = sourceRow + destinationRow;

                        //Ensure there will be a swap in the group
                        while (sourceRow == newRowIndex || newRowIndex < 1 || newRowIndex > 3)
                        {
                            if (sourceRow == newRowIndex)
                            {
                                destinationRow = randGenerator.Next(-2, 2);
                            }

                            if (sourceRow + destinationRow > 3)
                            {
                                destinationRow--;
                            }
                            else if (sourceRow + destinationRow < 1)
                            {
                                destinationRow++;
                            }
                            newRowIndex = sourceRow + destinationRow;
                        }

                        //Transform values to array indexer-friendly values.
                        sourceRow = sourceRow + SudokuGroupDimension * sourceGroup - 1;
                        newRowIndex = newRowIndex + SudokuGroupDimension * sourceGroup - 1;
                        SwapRows(sourceRow, newRowIndex);

                        break;
                    }
                #endregion
                #region Swap whole groups.
                case TransformType.SwapGroups:
                    {
                        int sourceGroup = randGenerator.Next(1, 3);
                        int destinationGroup = randGenerator.Next(-2, 2);
                        int newGroupIndex = sourceGroup + destinationGroup;

                        //Ensure there will be a swap within grid limits
                        while (sourceGroup == newGroupIndex || newGroupIndex < 1 || newGroupIndex > 3)
                        {
                            if (destinationGroup == 0)
                            {
                                destinationGroup = randGenerator.Next(-2, 2);
                            }

                            if (sourceGroup + destinationGroup > 3)
                            {
                                destinationGroup--;
                            }
                            else if (sourceGroup + destinationGroup < 1)
                            {
                                destinationGroup++;
                            }
                            newGroupIndex = sourceGroup + destinationGroup;
                        }

                        //Transform values to array indexer-friendly values.
                        sourceGroup--;
                        newGroupIndex--;
                        for (int row = 0; row < SudokuGroupDimension; row++)
                        {
                            SwapRows(row + SudokuGroupDimension * sourceGroup, row + SudokuGroupDimension * newGroupIndex);
                        }
                        break;
                    }
                #endregion
                #region Transpose whole grid across left-right diagonal.
                case TransformType.Transpose:
                    {
                        Transpose();
                        break;
                    }
                #endregion
            }
        }

        private void SwapRows(int row1, int row2)
        {
            int value;
            for (int col = 0; col < SudokuDimension; col++)
            {
                value = numbers[row1, col];
                numbers[row1, col] = numbers[row2, col];
                numbers[row2, col] = value;
            }
        }

        private void Transpose()
        {
            int value;
            for (int row = 0; row < SudokuDimension; row++)
            {
                for (int col = 0; col < SudokuDimension; col++)
                {
                    value = numbers[row, col];
                    numbers[row, col] = numbers[col, row];
                    numbers[col, row] = value;
                }
            }
        }

        public bool IsEditable(int row, int col)
        {
            return editableFlags[row, col];
        }
        
        public bool IsRowEmpty(int row)
        {
            for (int col = 0; col < SudokuDimension; col++)
            {
                if (numbers[row, col] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsSingleInRow(int row, int col)
        {
            for (int colIndex = 0; colIndex < col; colIndex++)
            {
                if (numbers[row, colIndex] != 0)
                {
                    return false;
                }
            }

            for (int colIndex = col + 1; colIndex < SudokuDimension; colIndex++)
            {
                if (numbers[row, colIndex] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(144);
            for (int group = 0; group < SudokuGroupDimension; group++)
            {
                for (int row = group * SudokuGroupDimension; row < SudokuGroupDimension * (group + 1); row++)
                {
                    output.AppendFormat("{0}{1}{2} {3}{4}{5} {6}{7}{8}\n",
                        numbers[row, 0], numbers[row, 1], numbers[row, 2],
                        numbers[row, 3], numbers[row, 4], numbers[row, 5],
                        numbers[row, 6], numbers[row, 7], numbers[row, 8]);
                }
                output.AppendLine();
            }

            return output.ToString();
        }

        public enum Difficulty
        {
            Easy, Medium, Hard
        }

        public enum TransformType
        {
            SwapRows, SwapGroups, Transpose
        }

    }
}
