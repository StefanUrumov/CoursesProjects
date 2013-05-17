using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    abstract class Account
    {
        string customer { get; set; }
        decimal balance { get; set; }
        Customer newCustomer;

        public Customer NewCustomer
        {
            get { return this.newCustomer; }
            set { this.newCustomer = value; }
        }

        public abstract decimal DepositMoney(decimal valueToDeposit);
        public abstract decimal Withdraw(decimal valueWithdraw);
        public abstract decimal CalculateInterest(decimal interest, int months, Customer newCustomer);
    }
}
