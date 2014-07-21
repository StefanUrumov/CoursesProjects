
namespace _1.TaskSchool
{
    using System;
    using System.Linq;

    public class CustomSchoolExeption : Exception
    {
        readonly string message;

        //constructors
        public CustomSchoolExeption()
        {
        }

        public CustomSchoolExeption(string errorMessage)
        {
            this.message = errorMessage;
        }
    }
}
