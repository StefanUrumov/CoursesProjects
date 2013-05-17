using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SoftwareAcademy
{
    class Teacher : ITeacher
    {
        private string name;
        private IList<ICourse> courses; 

        public string Name
        {
            get
            {
                return this.name = name;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("The name can not be null!");
                }

                this.name = value;
            }
        }

        public Teacher(string name)
        {
            this.name = name;
        }

        public Teacher(string name, IList<ICourse> courses)
        {
            this.name = name;
            this.courses = courses;
        }

        public void AddCourse(ICourse course)
        {
            courses = new List<ICourse>();
            courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            for (int index = 0; index < courses.Count; index++)
            {
                result.Append(courses[index]);
            
                if (index < courses.Count - 1)
                {
                    result.Append(", ");
                }
            }

           if (courses.Count == 0)
           {
               return String.Format("Teacher: Name= {0}", this.Name); 
           }
           else
           {
                return String.Format("Teacher: Name= {0}; Courses=[{1}]", this.Name,  result.ToString());
           }
            
        }
       
    }
}
