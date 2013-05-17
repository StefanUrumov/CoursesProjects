using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Individual : Customer
    {
        private string name;
        private string lastName;

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Individual()
        {
        }

        public Individual(string name, string lastName)
        {              
            this.name = name;
            this.lastName = lastName;
        }
    }
}
