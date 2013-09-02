
namespace Sudoku
{
    using System;
    using System.Linq;

    [Serializable]
    public class SudokuException : System.Exception
    {
        public SudokuException()
        : base() { }
    
        public SudokuException(string message)
        : base(message) { }
    
    //public SudokuException(string format, params object[] args)
    //    : base(string.Format(format, args)) { }
    
    //public SudokuException(string message, Exception innerException)
    //    : base(message, innerException) { }
    
    //public SudokuException(string format, Exception innerException, params object[] args)
    //    : base(string.Format(format, args), innerException) { }

    //protected SudokuException(SerializationInfo info, StreamingContext context)
    //    : base(info, context) { }

    }
}
