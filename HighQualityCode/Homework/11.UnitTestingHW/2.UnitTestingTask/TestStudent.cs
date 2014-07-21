
namespace _2.UnitTestingTask
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _1.TaskSchool;

    [TestClass]
    class TestStudent
    {
        [TestMethod]
        [ExpectedException(typeof(CustomSchoolExeption))]
        public void TestStudentNullName()
        {
            string name = string.Empty;
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
        }
    }
}
