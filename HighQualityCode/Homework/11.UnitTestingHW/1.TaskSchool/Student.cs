
namespace _1.TaskSchool
{
    using System;
    using System.Linq;

    public class Student : IStudent
    {
        //fields
        private string studentName;
        private int studentNumber;
             
        //properties
        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                if (value >= 10000 && value <= 99999)
                {
                    this.studentNumber = value;
                }
                else
                {
                    throw new CustomSchoolExeption("The unique number of the student must be in range [10 000...99 999]!");
                }
                
            }
        }

        public string StudentName
        {
            get
            {
                return this.studentName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.studentName = value;
                }
                else
                {
                    throw new CustomSchoolExeption("The name of the student can not be empty!");                
                }                
            }
        }

        //constuctorspublic Student(string name, int studentID)
        public Student(string studentName, int studentNumber)    
        {
            this.StudentName = studentName;
            this.StudentNumber = studentNumber;
        }
    }
}
