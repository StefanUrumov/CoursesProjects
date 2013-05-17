
namespace _1.TaskSchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ISchool
    {
        string SchoolName { get; set; }
        IEnumerable<Course> SetOfCourses { get; set; }
    }
}
