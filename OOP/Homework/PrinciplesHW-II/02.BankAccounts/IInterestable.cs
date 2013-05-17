using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    interface IInterestable
    {
        decimal Interest { get; set;}
        int Months { get; set; }

        decimal ClaculateInterest(decimal interest, int months, Customer newCustomer);
    }
}
