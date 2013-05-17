using System;
using System.Collections.Generic;

public class SortingArrays
{
    private class NumbersComparer : IComparer<int> 
    {
        public int Compare(int x, int y)
        {
            return (x % 5).CompareTo(y % 5);
        }
    }

    class StudentsComparer:IComparer<string>
    {
        public int Compare(string student1, string student2)
        {
            var lastName1 = student1.Substring(student1.IndexOf(' ') + 1);
            var lastName2 = student2.Substring(student2.IndexOf(' ') + 1);
            return lastName1.CompareTo(lastName2);

            //sort by lastname length and alphabeticaly
            //var last1NameLen = lastName1.Length;
            //var last2NameLen = lastName2.Length;
            //
            //if (last1NameLen == last2NameLen)
            //{
            //    lastName1.CompareTo(lastName2);
            //}
            //return last1NameLen.CompareTo(last2NameLen);

            //get only first name
            //int first1SpaceIndex = student1.IndexOf(' ');
            //string first1Name = student1.Substring(0, first1SpaceIndex);
            //int first2SpaceIndex = student2.IndexOf(' ');
            //string first2Name = student1.Substring(0, first2SpaceIndex);
        
        }
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 5, 10, 11 };

        Array.Sort(numbers, new NumbersComparer());

        Console.WriteLine("Numbers sorted by modul 5");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        Array.Sort(numbers, (x, y) => (y%6).CompareTo(x%6));

        Console.WriteLine("Numbers sorted descending:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
        
        string[] students = { "Doncho Minkov", "Nikolay Kostov", 
                                "Pesho Stefanov", "Stamat Georgiev", "Khan Asparukh" };
        Array.Sort(students, new StudentsComparer());
        //Array.Sort(students, (x,y) =>
        //    x.Substring(x.LastIndexOf(" ") + 1).CompareTo(y.Substring(y.LastIndexOf(" ") + 1))); //+1 because we don't need the " " itself
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
