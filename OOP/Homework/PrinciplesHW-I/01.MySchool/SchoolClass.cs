using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MySchool
{
    class SchoolClass 
    {
        //Fields
        private List<Student> students;
        private List<Teacher> teachers;
        private List<String> comments;
        private string id;

        //Properties
        public Student[] Students
        {
            get { return this.students.ToArray(); }
            private set { }
        }

        public Teacher[] Teachers
        {
            get { return this.teachers.ToArray(); }
            private set { }
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string[] Comments
        {
            get { return this.comments.ToArray(); }
        }

        //Constructors
        public SchoolClass(Student[] students, Teacher[] teachers, string id)
        {
            this.students = new List<Student>(students);
            this.teachers = new List<Teacher>(teachers);
            this.id = id;
            this.comments = new List<string>();
        }

        //Methods 
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }

    }
}
