using System;
using System.Linq;

namespace FirstTask
{
    public class ExampleClass
    {
        private const int MaxCount = 6;

        public static int MaximumCount
        {
            get
            {
                return MaxCount;
            }
        }

        public static void Main()
        {
            ExampleClass testMyClasses = new AnotherExampleClass();
            testMyClasses.ConvertBoolVariableToString(true);
        }

        //by the inheritance between ExampleClass and AnotherExampleClass I can level up the abstraction
        // in the Main method
        public virtual void ConvertBoolVariableToString(bool isTrue)
        {
        }
    }
}
