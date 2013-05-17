using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanBeing
{
    class Student : Human
    {        
        public int Grade { get; set; }
               
        public Student(string name, string lastName, int grade)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Grade = grade;
        }

    }
}
