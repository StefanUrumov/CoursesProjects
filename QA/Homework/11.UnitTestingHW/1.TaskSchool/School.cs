
namespace _1.TaskSchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School : ISchool
    {
        //I assume in this task, that is more appropriate the school to have a set of courses than students
        private string schoolName;
        private IEnumerable<Course> setOfCourses;
        private IEnumerable<Student> studentsList;

        public IEnumerable<Student> StudentsList
        {
            get
            {
                return this.studentsList;
            }
            set
            {
                this.studentsList = value;
            }
        }

        public IEnumerable<Course> SetOfCourses
        {
            get
            {
                return this.setOfCourses;
            }
            set
            {
                this.setOfCourses = value;
            }
        }

        public string SchoolName
        {
            get
            {
                return this.schoolName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {                 
                    this.schoolName = value;   
                }
                else
                {
                    throw new CustomSchoolExeption("The course name cannot be null or empty!");
                }                
            }
        }

        public School(string schoolName, IEnumerable<Student> studentsList, IEnumerable<Course> setOfCourses)
        {
            this.SchoolName = schoolName;
            this.StudentsList = studentsList;
            this.SetOfCourses = setOfCourses;
        }
    }
}
