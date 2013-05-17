using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Deposit : Account, IInterestable
    {
        private string customer;
        private decimal balance;
        private decimal interest;
        private int months;

        public string Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal Interest
        {
            get { return this.interest; }
            set { this.interest = value; }
        }


        public int Months
        {
            get { return this.months; }
            set { this.months = value; }
        }

        public Deposit(string customer, decimal balance)
        {
            this.customer = customer;
            this.balance = balance;
        }

        public override decimal DepositMoney(decimal valueToDeposit)
        {
            //valueToDeposit = 0;
            balance += valueToDeposit;

            return this.balance;
        }


        public override decimal Withdraw(decimal valueWithdraw)
        {
            //valueWithdraw = 0;
            
            if (valueWithdraw <= balance) //check incorrect operation
            {
                balance -= valueWithdraw;
                return balance;
            }

            return balance;
        }

        public override decimal CalculateInterest(decimal interest, int months, Customer newCustomer)
        {
            decimal interestAmount = 0;

            if (balance < 1000 && balance > 0)
            {
                interestAmount = 0;
            }
            else
            {
                interestAmount = interest * months;
            }           

            return interestAmount;
        }
    }
}
