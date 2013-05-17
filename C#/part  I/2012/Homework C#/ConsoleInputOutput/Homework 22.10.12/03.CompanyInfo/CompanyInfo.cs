using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            Console.WriteLine("Please enter company name:");
            string companyName = Console.ReadLine();

            Console.WriteLine("Please enter company adress:");
            string companyAdress = Console.ReadLine();

            Console.WriteLine("Please enter company phone number:");
            Console.WriteLine("you can use symbols - example: 0888 BUY BMW");
            string companyNumber = Console.ReadLine();

            Console.WriteLine("Please enter company fax number:");
            string companyFax = Console.ReadLine();

            Console.WriteLine("Please enter company web site:");
            string companyWeb = Console.ReadLine();

            Console.WriteLine("Please enter information about the manager:");
            Console.WriteLine("- first name:");
            string manFiName = Console.ReadLine();
            Console.WriteLine("- last name:");
            string manLaName = Console.ReadLine();
            Console.WriteLine("- age:");
            byte manAge = byte.Parse(Console.ReadLine());
            Console.WriteLine("- phone number (+359 - ):");
            string manPhone = Console.ReadLine();

            Console.WriteLine("If you filled the form correctly: The company is {0} with adress: {1}, you can find us at: \n number: {2} \n fax: {3} \n website: {4} \n or contact our manager \n {5} {6}, {7} years old \n phone number:  +359 - {8}  ", companyName, companyAdress, companyNumber, companyFax, companyWeb, manFiName, manLaName, manAge, manPhone);
        
        
        
        }
    }
}
