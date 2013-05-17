using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Company : Customer
    {
        private string name;
        private string type;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public Company()
        {
        }

        public Company(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
    
    }
}
