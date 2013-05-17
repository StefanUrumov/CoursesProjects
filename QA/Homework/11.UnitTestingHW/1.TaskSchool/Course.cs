
namespace _1.TaskSchool
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Course : ICourse
    {
        //fields
        private const int MaxNumberOfStudentsInCourse = 30;
        private IList<Student> setOfStudents = new List<Student>();
        private string courseName;
        
        //properties
        public IList<Student> SetOfStudents
        {
            get
            {
                return this.setOfStudents;
            }
            //maybe protected set!?
            set
            {                   
                this.setOfStudents = value;                
            }
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.courseName = value;
                }
                else
                {
                    throw new CustomSchoolExeption("The course name cannot be null or empty!");
                }
            }
        }

        //constructors
        public Course(string courseName)
        {
            this.CourseName = courseName;            
        }

        public Course(string courseName, IList<Student> studentsList)
        {            
            this.CourseName = courseName;
            this.SetOfStudents = new List<Student>(studentsList);           
        }

        //methods
        public void Leave(Student candidate)
        {
            if (this.IsStudentFound(candidate))
            {
                this.SetOfStudents.Remove(candidate);
            }
            else
            {
                throw new CustomSchoolExeption("This student is not in the course!");
            }           
        }

        public void Join(Student candidate)
        {
            if (this.IsStudentFound(candidate))
            {
                throw new CustomSchoolExeption("This student already joined the course!");
            }
            if (this.IsCourseFull())
            {
                throw new CustomSchoolExeption("This student can not join, because the course is already full!");
            }

            this.SetOfStudents.Add(candidate);
        }
        
        private bool IsStudentFound(Student candidate)
        {
            for (int i = 0; i < this.SetOfStudents.Count; i++)
            {
                if (candidate.StudentNumber == this.SetOfStudents[i].StudentNumber)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsCourseFull()
        {
            if (this.SetOfStudents == null)
            {
                return false;
            }
            else if (this.SetOfStudents.Count >= MaxNumberOfStudentsInCourse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (IEnumerator student in this.SetOfStudents)
            {
                yield return student;
            }
        }
    }
}
