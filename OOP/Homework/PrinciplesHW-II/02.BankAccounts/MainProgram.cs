using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class MainProgram
    {
        static void Main()
        {
            Customer Bob = new Individual("Bob", "Sideshow");
            Customer Iron = new Company("Iron", "Ltd.");

            Account depo = new Deposit("bob", 1200.00m);
            depo.NewCustomer = Bob;
            depo.DepositMoney(100.50m);
            depo.Withdraw(50.10m);
            Console.WriteLine(  depo.CalculateInterest(3.5m, 24, Bob) );

            Account lo = new Loan("Iron Ltd.", 3210000.123m);
            lo.NewCustomer = Iron;
            lo.DepositMoney(2000.001m);
            lo.Withdraw(20111.1m);
            Console.WriteLine( lo.CalculateInterest(9.10m, 52, Iron) );
        }
    }
}
