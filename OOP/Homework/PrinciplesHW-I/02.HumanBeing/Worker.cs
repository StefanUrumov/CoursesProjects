using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanBeing
{
    class Worker : Human
    {
        //Fields
        private decimal weekSalary;
        private decimal workHoursPerDay;

        //Properties
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }
        //Constructors
        public Worker(string name, string lastName, decimal weekSalary, decimal workHoursPerDay)
        {
            this.Name = name;
            this.LastName = lastName;
            this.workHoursPerDay = workHoursPerDay;
            this.weekSalary = weekSalary;
        }

        //Methods 
        public decimal MoneyPerHour() 
        {
            return weekSalary / (workHoursPerDay * 5.0m);
        }
        

    }
}
