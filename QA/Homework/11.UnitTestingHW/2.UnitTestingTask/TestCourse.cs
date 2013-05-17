
namespace _2.UnitTestingTask
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _1.TaskSchool;

    [TestClass]
    class TestCourse
    {
        [TestMethod]
        public void TestIsCourseValid()
        {
            IList<Student> myList = new List<Student>();
            Course myCourse = new Course("HTML", myList);
            Assert.IsNotNull(myCourse);
        }

        [TestMethod]
        public void TestCourseExecuteStudentJoin()
        {
            Course myCourse = new Course("HTML");
            Student pesho = new Student("Pesho", 22222);
            Student ivan = new Student("Ivan", 33333);
            Student gosho = new Student("Gosho", 44444);

            myCourse.Join(pesho);
            myCourse.Join(ivan);
            myCourse.Join(gosho);

            Assert.IsTrue(myCourse.SetOfStudents.Count == 3);
        }

        //[TestMethod]
        //public void TestCourseIsStudentFound()
        //{
        //    Student pesho = new Student("Pesho", 22222);
        //    Student ivan = new Student("Ivan", 33333);  
          
        //    //IList<Student> list = new List<Student>();
        //    //list.Add(pesho);
        //    //list.Add(ivan);

        //    Course course = new Course("QA");
        //    course.Join(pesho);


        //    //set the method to public for this test
        //    Assert.IsTrue(course.IsStudentFound(pesho));

        //}
    }
}
