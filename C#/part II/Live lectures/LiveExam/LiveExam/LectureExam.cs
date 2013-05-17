using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LiveExam
{
    class LectureExam
    {
        static void Main()
        {
            string text = "some text";
            string  path = "../../test.txt";
            StreamWriter sw = new StreamWriter(path, true);

             using(sw)
	        {
	        	 sw.WriteLine("One test!");
                 sw.WriteLine(text);
	        }

        }
    }
}
