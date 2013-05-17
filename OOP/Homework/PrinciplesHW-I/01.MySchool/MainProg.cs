using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MySchool
{
    class MainProg
    {
        static void Main()
        {
            Student i = new Student("Ivancho", 1);            
            Student a = new Student("Ani", 2);
            Student v = new Student("Vader", 3);
            Student h = new Student("Homer", 4);

            Teacher p = new Teacher("Petkan");
            p.Discipline = Disciplines.Biology.ToString();
            Teacher m = new Teacher("Mony");
            p.Discipline = Disciplines.Math.ToString();

            Teacher[] teachers = new Teacher[] {p, m};
            Student [] students = new Student[] {i, a, v, h};
            SchoolClass firstA = new SchoolClass(students, teachers, "First A");

            Discipline OOP = new Discipline();
            OOP.AddComment("Great!");
            
        }
    }
}
