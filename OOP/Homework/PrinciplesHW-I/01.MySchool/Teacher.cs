using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MySchool
{
    public enum Disciplines //:Discipline
    {
        History,
        Math,
        Language,
        Biology
    }
        
    class Teacher : People
    {
        private string name;
        string discipline;
       
        public string Name
        {
            get { return this.Name = name; }
            set { this.name = value; }
        }

        public Teacher(string name)
        {
            this.name = name;
        }

        public string  Discipline
        {
            get { return this.Discipline = discipline; }
            set { this.discipline = value; }
        }

    }
}
