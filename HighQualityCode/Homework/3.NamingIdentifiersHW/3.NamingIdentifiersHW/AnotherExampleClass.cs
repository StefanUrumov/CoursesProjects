using System;
using System.Linq;

namespace FirstTask
{
    class AnotherExampleClass : ExampleClass
    {
        public override void ConvertBoolVariableToString(bool isTrue)
        {
            string boolAsString = isTrue.ToString();
            Console.WriteLine(boolAsString);
        }
    }
}
