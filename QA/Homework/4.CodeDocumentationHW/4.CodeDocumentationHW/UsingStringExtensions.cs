using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.ILS.Common
{
    class UsingStringExtensions
    {
        static void Main()
        {
            string testString = "This is test text string.exe";
            testString.ToByteArray();
            Console.WriteLine(testString.ConvertLatinToCyrillicKeyboard());
            Console.WriteLine(testString.GetFileExtension());
        }
    }
}
