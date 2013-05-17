using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Person
{
    class Person
    {
        //fileds
        private string name;
        private int? age;

        //properties
        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //constructors
        public Person(string name, int? age = null)        
        {
            this.name = name;
            this.age = age;
        }

        //methods
        public override string ToString()
        {
            string msg = string.Empty;
            if (age == null)
            {
                msg += "age not specified";
            }
            else
            {
                msg += age;
            }
            return msg;
        }
    }
}
