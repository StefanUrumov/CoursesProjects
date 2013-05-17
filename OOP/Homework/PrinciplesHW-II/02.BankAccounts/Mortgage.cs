using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Mortgage : Account, IInterestable
    {
        private string customer;
        private decimal balance;
        private decimal interest;
        private int months;

        public string Customer
        {
            get { return this.Customer = customer; }
            private set { this.customer = value; }
        }

        protected decimal Balance
        {
            get { return this.Balance = balance; }
            private set { this.balance = value; }
        }

        public decimal Interest
        {
            get { return this.Interest = interest; }
            set { this.interest = value; }
        }


        public int Months
        {
            get { return this.Months = months; }
            set { this.months = value; }
        }

        public Mortgage(string customer, decimal balance)
        {
            this.customer = customer;
            this.balance = balance;
        }

        public override decimal DepositMoney(decimal valueToDeposit)
        {
            valueToDeposit = 0;
            balance += valueToDeposit;

            return balance;
        }


        public override decimal Withdraw(decimal valueWithdraw)
        {
            throw new ArgumentException("Only deposit bank account can withdraw money!");            
        }

        public override decimal CalculateInterest(decimal interest, int months, Customer NewCustomer)
        {
            decimal interestAmount = 0;
            
            if (NewCustomer == new Individual() && months < 6)
            {
                interestAmount = 0;   
            }
            if (NewCustomer == new Company() && months < 12)
            {
                interestAmount = (interest / 2)* months;
            }
            else
            {
                interestAmount = interest * months;
            }
           
            return interestAmount;
        }
        
    }
}
