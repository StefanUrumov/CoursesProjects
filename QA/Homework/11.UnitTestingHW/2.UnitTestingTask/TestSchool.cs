
namespace _2.UnitTestingTask
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _1.TaskSchool;

    [TestClass]
    class TestSchool
    {
        [TestMethod]
        public void TestSchoolConstructorIsValid()
        {
            Course qA = new Course("QA");
            Course cSharp = new Course("CSharp");
            Course hTml = new Course("HTML");

            List<Course> myCourses = new List<Course>();
            myCourses.Add(qA);
            myCourses.Add(cSharp);
            myCourses.Add(hTml);

            Student pesho = new Student("Pesho", 22222);            
            Student ivan = new Student("Ivan", 33333);            
            Student gosho = new Student("Gosho", 44444);
            
            List<Student> myStudents = new List<Student>();
            myStudents.Add(pesho);
            myStudents.Add(ivan);
            myStudents.Add(gosho);

            School mySchool = new School("108 COY", myStudents, myCourses);

            Assert.IsNotNull(mySchool);
        }
    }
}
