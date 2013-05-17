using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MySchool
{
    class Student : People
    {
        private string name;
        private int studentClassNumber;

        public string Name
        {
            get { return this.Name = name; }
            set { this.name = value; }
        }

        public int StudentClassNumber
        {
            get { return this.StudentClassNumber = studentClassNumber; }
            set { this.studentClassNumber = value; }
        }

        public Student(string name, int studentClassNumber)
        {
            this.name = name;
            this.studentClassNumber = studentClassNumber;
        }
        
    }
}
