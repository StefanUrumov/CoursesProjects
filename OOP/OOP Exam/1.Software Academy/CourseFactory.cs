using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            ITeacher teacher = new Teacher(name);
            return teacher;
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab) //TODO maybe return type should be ICourse
        {
            ILocalCourse localCourse = new LocalCourse();
            return localCourse;
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            IOffsiteCourse offsiteCourse = new OffsiteCourse();
            return offsiteCourse;
        }
    }
}
