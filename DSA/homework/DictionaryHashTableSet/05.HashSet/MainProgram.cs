
namespace _05.HashSet
{
    using System;
    using System.Linq;

    class MainProgram
    {
        static void Main(string[] args)
        {
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("try");
            hashSet.Add("Test");


            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
