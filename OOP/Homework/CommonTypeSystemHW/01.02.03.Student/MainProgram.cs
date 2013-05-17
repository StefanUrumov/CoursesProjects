using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    class MainProgram
    {
        static void Main()
        {
            Student s1 = new Student("Ivan", "Ivanov", "Ivanov", 0011223344, "Sofia", "ivan4o@mail.ru", 4, Specialties.ComputerScience, Universities.SofiaUniversity, Faculties.FMI);

            Student s2 = new Student("Gogo", "Georgiev", "Ivanov", 1122334455, "Sofia", "some@mail.us", 2, Specialties.Law, Universities.TechnicalUniversity, Faculties.FacultyOfLaw);

            Console.WriteLine("s1 HashCode: " + s1.GetHashCode());
            Console.WriteLine("s1 HashCode: " + s2.GetHashCode());
            Console.WriteLine("s1 equals s2: " + s1.Equals(s2));
            Console.WriteLine("s1 == s2: " + (s1 == s2));
            Console.WriteLine("s1 != s2: " + (s1 != s2));
            Console.WriteLine();
            Console.WriteLine(s2.ToString());
            Console.WriteLine();

            Student s3 = (Student)s2.Clone();

            Console.WriteLine("s2 == s3: " + (s2 == s3));
            Console.WriteLine("s2 != s3: " + (s2 != s3));
            Console.WriteLine("s2.CompareTo(s3): " + s2.CompareTo(s3));
            Console.WriteLine("s1.CompareTo(s2): " + s1.CompareTo(s2));
        
        }
    }
}
