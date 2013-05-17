using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    class LocalCourse : ILocalCourse
    {        
        private string lab;
        
        public string Lab
        {
            get
            {
                return this.lab = lab;
            }
            set
            {
                if (value == null)
                {                   
                    throw new ArgumentNullException("The name of the lab can not be null!");
                }

                this.lab = value;
            }
        }

        public string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name can not be null!");
                }

                this.Name = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.Teacher = Teacher;
            }
            set
            {
                this.Teacher = value;
            }
        }

        public IList<string> CourseProgram  
        {
            get { return this.CourseProgram = CourseProgram; }
            set { this.CourseProgram = value; }
        }

        public void AddTopic(string topic)
        {
            CourseProgram = new List<string>();
            CourseProgram.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            bool first = true;
            foreach (var course in CourseProgram)
            {
                if (course != null)
                {
                    if (!first)
                    {
                        result.Append(", ");
                    }
                    result.AppendFormat("{0}", course);
                    first = false;
                }
            }

            if (this.Teacher == null)
            {
                return String.Format("{0}: Name={1}; Topics=[{3}]; Lab={4}", this.GetType(), this.GetType().Name, result.ToString(), this.Lab);
            }

            if(result.ToString() == string.Empty)
            {
                return String.Format("{0}: Name={1}; Teacher={2}; Lab={4}", this.GetType(), this.GetType().Name, this.Teacher.Name, this.Lab);        
              
            }

            return String.Format("{0}: Name={1}; Teacher={2}; Topics=[{3}]; Lab={4}", this.GetType(), this.GetType().Name, this.Teacher.Name, result.ToString(), this.Lab);        
            

        }

    }
}
