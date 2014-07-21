
namespace _1.TaskSchool
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public interface ICourse : IEnumerable
    {       
        IList<Student> SetOfStudents { get; set; }

        void Leave(Student candidate);

        void Join(Student candidate);       
    }
}
