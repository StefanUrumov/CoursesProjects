namespace _1.RefactorVariableNaming
{
    using System;
    using System.Linq;

    public class ManageFigureSize
    {
        public static void Main()
        {
            Size testFigure = new Size(5.5, 3.7);
            testFigure.GetRotatedSize(testFigure, 90.5);
            Console.WriteLine(testFigure.ToString());
        }
    }
}
