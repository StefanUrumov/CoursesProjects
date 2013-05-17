using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftwareAcademy
{
    public abstract class Course : ICourse
    {
        private string name;
        private string topic;
        private IList<string> courseProgram; 

        public string Name
        {
            get
            {
                return this.name = name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name can not be null!");
                }

                this.name = value;
                
            }
        }

        public string Topic
        {
            get { return this.topic = topic; }
            set 
            {
                 if(value == null)
                {
                    throw new ArgumentNullException("The name of the topic can not be null!");
                }

                this.name = value;                    
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
                //can be passed as null
                this.Teacher = value;
            }
        }

        protected IList<string> CourseProgram //TODO maybe protected?
        {
            get { return this.courseProgram = courseProgram; }
            set { this.courseProgram = value; }
        }

        public void AddTopic(string topic)
        {
            CourseProgram = new List<string>();
            CourseProgram.Add(Topic);
        }
    }
}
