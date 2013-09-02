using System;
using System.IO;

namespace Sudoku
{
    class GameWindow
    {
        private const int WindowWidth = 60;
        private const int WindowHeight = 31;
        private const int FirstCellRowPosition = 8;
        private const int FirstCellColPosition = 18;
        private const int CellPositionRowIncrements = 2;
        private const int CellPositionColIncrements = 3;
        private const int MenuItemsCellRowPosition = 3;
        private readonly int[] MenuItemsCellColPositions = { 3,11,23,32,41,51};
        

        public const ConsoleColor BackgroundColor = ConsoleColor.White;
        public const ConsoleColor BoxBorderColor = ConsoleColor.DarkCyan;
        public const ConsoleColor WrongEntryBackGroundColor = ConsoleColor.Red;
        public const ConsoleColor LockedEntryDigitColor = ConsoleColor.DarkGray;
        public const ConsoleColor EntryDigitColor = ConsoleColor.Black;
        public const ConsoleColor HighlightBackGroundColor = ConsoleColor.DarkCyan;
        public const ConsoleColor HighlightForeGroundColor = ConsoleColor.Black;
        public const ConsoleColor MenuForeGroundColor = ConsoleColor.Black;



        private const string WindowBoxFilePath = "GameBox.txt";
        private readonly string[] MenuItemLabels = { "New", "Restart", "Save", "Load", "Solve", "Exit" };

        private static bool gameIsRunning = true;

        private SudokuCell[,] cells;
        private MenuCell[] menuCells;
        public static SudokuCell CurrentCell;
        
        private SudokuGrid grid;
        public static int CurrentCellRowIndex;
        public static int CurrentCellColIndex;
        private MenuItem currentMenuItem;
        private int currentMenuItemIndex;

        public GameWindow()
        {
            grid = SudokuGenerator.Generate(SudokuGrid.Difficulty.Easy);
            InitWindow();
            InitCells(grid);
            currentMenuItem = MenuItem.None;
            currentMenuItemIndex = 0;
            gameIsRunning = true;
        }

        //Starts the main game loop.
        public void StartMainLoop()
        {
            while (gameIsRunning)
            {
                //Check if any keys where pressed
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    switch (pressedKey.Key)
                    { 
                        //Procedure for moving the cursor
                        case ConsoleKey.LeftArrow:
                        case ConsoleKey.RightArrow:
                        case ConsoleKey.UpArrow:
                        case ConsoleKey.DownArrow:
                            MoveCursor(pressedKey.Key);
                            break;
                        
                        //Procedure for selecting an item from the menu
                        case ConsoleKey.Enter:
                            if (currentMenuItem != MenuItem.None)
                            {
                                OnMenuItemSelected(currentMenuItem);
                            }
                            break;

                        //Prcedure for entering or changing a number in the sudoku grid
                        case ConsoleKey.D1:
                        case ConsoleKey.D2:
                        case ConsoleKey.D3:
                        case ConsoleKey.D4:
                        case ConsoleKey.D5:
                        case ConsoleKey.D6:
                        case ConsoleKey.D7:
                        case ConsoleKey.D8:
                        case ConsoleKey.D9:
                            if (CurrentCellRowIndex != -1)
                            {
                                grid.WriteNumber(CurrentCellRowIndex, CurrentCellColIndex, (pressedKey.KeyChar - '0'));
                                RefreshCellValues();

                                //test
                                if (grid.EmptyCells == 0)
                                    Close();
                            }
                            break;
                        //Procedure for deleting a number
                        case ConsoleKey.Backspace:
                            if (CurrentCellRowIndex != -1)
                            {
                                grid.WriteNumber(CurrentCellRowIndex, CurrentCellColIndex, SudokuGrid.EmptyCellValue);
                                RefreshCellValues();
                            }
                            break;

                    }

                    
                    
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                }
            }
        }

        //Stops main loop and restores console appearance
        public void StopMainLoop()
        {
            gameIsRunning = false;
        }

        private void InitCells(SudokuGrid grid)
        {
            //Initialize and set highlighted cell.
            CurrentCell = new SudokuCell(FirstCellRowPosition, FirstCellColPosition);
            CurrentCellRowIndex = 0;
            CurrentCellColIndex = 0;

            //Initialize other number fields.
            const int SudokuDim = SudokuGrid.SudokuDimension;
            cells = new SudokuCell[SudokuDim,SudokuDim];
            int currWindowRowPos = GameWindow.FirstCellRowPosition;
            int currWindowColPos = GameWindow.FirstCellColPosition;
            const int RowIncrement = GameWindow.CellPositionRowIncrements;
            const int ColIncrement = GameWindow.CellPositionColIncrements;

            for (int row = 0; row < SudokuDim; row++)
            {
                for (int col = 0; col < SudokuDim; col++)
                {
                    cells[row, col] = new SudokuCell(grid[row, col], grid.IsEditable(row, col), currWindowRowPos, currWindowColPos);
                    currWindowColPos += ColIncrement;
                }
                currWindowColPos = GameWindow.FirstCellColPosition;
                currWindowRowPos += RowIncrement;
            }

            //Initialize menu items
            menuCells = new MenuCell[MenuItemLabels.Length];
            for (int item = 0; item < menuCells.Length; item++)
            {
                menuCells[item] = new MenuCell(MenuItemsCellRowPosition, MenuItemsCellColPositions[item], MenuItemLabels[item]);
            }
            RedrawCells();
        }

        private void RedrawCells()
        {
            //Refresh number cells
            for (int row = 0; row < SudokuGrid.SudokuDimension; row++)
            {
                for (int col = 0; col < SudokuGrid.SudokuDimension; col++)
                {
                    cells[row, col].Redraw();
                }
            }

            //Refresh menu items
            for (int item = 0; item < menuCells.Length; item++)
            {
                menuCells[item].Redraw();
            }
        }
        
        private void RefreshCellValues()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    cells[row, col].Write(grid[row,col]);
                }
            }
        }

        private void InitWindow()
        {
            //Set window size and buffer
            Console.SetWindowSize(WindowWidth, WindowHeight);
            Console.SetBufferSize(WindowWidth, WindowHeight);

            //Hide cursor
            Console.CursorVisible = false;

            DrawWindow();
        }

        private void DrawWindow()
        {
            //Get window contents from the specified fie.
            string windowBuffer = ReadWindowBoxFromFile(WindowBoxFilePath);

            //Draw the base without the numbers
            Console.BackgroundColor = BackgroundColor;
            
            //Start drawing the borders
            Console.ForegroundColor = BoxBorderColor;
            Console.SetCursorPosition(0, 0);
            Console.Write(windowBuffer);

            //Redraw the cells
            //RedrawCells();

        }

        private void MoveCursor(ConsoleKey direction)
        {
            switch (direction)
            {
                #region Left
                case ConsoleKey.LeftArrow:
                    if (CurrentCellRowIndex > -1)
                    {
                        if (CurrentCellColIndex > 0)
                        {
                            CurrentCell.ColumnPosition -= CellPositionColIncrements;
                            CurrentCellColIndex--;
                        }
                    }
                    else if(currentMenuItemIndex>0)
                    {
                        currentMenuItemIndex--;
                        CurrentCell.ColumnPosition = MenuItemsCellColPositions[currentMenuItemIndex];
                        SettMenuItemFromMenuIndex();
                    }
                    break;
                #endregion
                #region Right
                case ConsoleKey.RightArrow:
                    if (CurrentCellRowIndex > -1)
                    {
                        if (CurrentCellColIndex < SudokuGrid.SudokuDimension - 1)
                        {
                            CurrentCell.ColumnPosition += CellPositionColIncrements;
                            CurrentCellColIndex++;
                        }
                    }
                    else if (currentMenuItemIndex < MenuItemsCellColPositions.Length-1)
                    {
                        currentMenuItemIndex++;
                        CurrentCell.ColumnPosition = MenuItemsCellColPositions[currentMenuItemIndex];
                        SettMenuItemFromMenuIndex();
                    }
                    break;
                #endregion
                #region Up
                case ConsoleKey.UpArrow:
                    if (CurrentCellRowIndex > 0)
                    {
                        CurrentCell.RowPosition -= CellPositionRowIncrements;
                        CurrentCellRowIndex--;
                    }
                    //procedure to enter menu items
                    else if (CurrentCellRowIndex == 0)
                    {
                        CurrentCellRowIndex = -1;
                        CurrentCell.RowPosition = MenuItemsCellRowPosition;
                        
                        if (CurrentCellColIndex < 2)
                        {
                            currentMenuItemIndex = 1;
                        }
                        else if (CurrentCellColIndex < 4)
                        {
                            currentMenuItemIndex = 2;
                        }
                        else if (CurrentCellColIndex < 7)
                        {
                            currentMenuItemIndex = 3;
                        }
                        else
                        {
                            currentMenuItemIndex = 4;
                        }
                        CurrentCell.ColumnPosition = MenuItemsCellColPositions[currentMenuItemIndex];
                        SettMenuItemFromMenuIndex();
                    }
                    break;
                #endregion
                #region Down
                case ConsoleKey.DownArrow:
                    if (CurrentCellRowIndex!=-1 && CurrentCellRowIndex < SudokuGrid.SudokuDimension - 1)
                    {
                        CurrentCell.RowPosition += CellPositionRowIncrements;
                        CurrentCellRowIndex++;
                    }
                    //procedure to leave menu items
                    else if (CurrentCellRowIndex == -1)
                    {
                       CurrentCellRowIndex = 0;
                       CurrentCell.RowPosition = FirstCellRowPosition;
                       currentMenuItem = MenuItem.None;

                        if (CurrentCell.ColumnPosition == MenuItemsCellColPositions[0] 
                            ||CurrentCell.ColumnPosition == MenuItemsCellColPositions[1])
                        {
                            CurrentCell.ColumnPosition = cells[0,0].ColumnPosition;
                            CurrentCellColIndex = 0;
                        }
                        else if (CurrentCell.ColumnPosition == MenuItemsCellColPositions[2])
                        {
                            CurrentCell.ColumnPosition = cells[0,2].ColumnPosition;
                            CurrentCellColIndex = 2;
                        }
                        else if (CurrentCell.ColumnPosition == MenuItemsCellColPositions[3])
                        {
                            CurrentCell.ColumnPosition = cells[0, 5].ColumnPosition;
                            CurrentCellColIndex = 4;
                        }
                        else 
                        {
                            CurrentCell.ColumnPosition = cells[0, 8].ColumnPosition;
                            CurrentCellColIndex = 8;
                        }
                    }
                    break;
                #endregion
            }
            RedrawCells();
        }

        private void SettMenuItemFromMenuIndex()
        {
            switch (currentMenuItemIndex)
            {
                case 0:
                    currentMenuItem = MenuItem.New;
                    break;
                case 1:
                    currentMenuItem = MenuItem.Restart;
                    break;
                case 2:
                    currentMenuItem = MenuItem.Save;
                    break;
                case 3:
                    currentMenuItem = MenuItem.Load;
                    break;
                case 4:
                    currentMenuItem = MenuItem.Solve;
                    break;
                case 5:
                    currentMenuItem = MenuItem.Exit;
                    break;
            }
        }

        private void OnMenuItemSelected(MenuItem item)
        {
            switch (item)
            { 
                case MenuItem.New:
                    NewGame(SudokuGrid.Difficulty.Easy);
                    break;
                case MenuItem.Restart:
                    RestartSudoku();
                    break;
                case MenuItem.Save:
                    break;
                case MenuItem.Load:
                    break;
                case MenuItem.Solve:
                    SolveSudoku();
                    break;
                case MenuItem.Exit:
                    Close();
                    break;
            }
        }

        private static string ReadWindowBoxFromFile(string filepath)
        {
            string output = null;
            using (StreamReader reader = new StreamReader(filepath))
            {
                output = reader.ReadToEnd();
            }
            return output;
        }

        private void NewGame(SudokuGrid.Difficulty difficulty)
        {
            grid = SudokuGenerator.Generate(difficulty);
            
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    cells[row, col].RefreshValues(grid[row, col], grid.IsEditable(row, col));
                }
            }
            RefreshCellValues();

        }
        
        private void RestartSudoku()
        {
            grid.ClearUserCells();
            RefreshCellValues();
            RedrawCells();
        }

        private void SolveSudoku()
        {
            //Clear user input
            grid.ClearUserCells();

            //Init solver and do magic
            SudokuSolver solver = new SudokuSolver(grid);
            solver.Solve();
            RefreshCellValues();
        }

        public void Close()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //Set window size and buffer
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 300);

            //Unhide cursor
            Console.CursorVisible = true;

            StopMainLoop();

        }

        enum MenuItem
        { 
            New,
            Restart,
            Save,
            Load,
            Solve,
            Exit,
            None
        }
    }
}
