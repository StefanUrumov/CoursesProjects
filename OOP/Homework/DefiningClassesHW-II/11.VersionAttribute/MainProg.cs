using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.VersionAttribute
{
    [GetVersion(1,2)]
    class MainProg
    {
        static void Main()
        {
            try
            {
                Type type = typeof(MainProg);
                object[] allAttributes = type.GetCustomAttributes(false);
                foreach (GetVersion versionAttribute in allAttributes)
                {
                    Console.WriteLine("The version of the class is {0} ", versionAttribute);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
