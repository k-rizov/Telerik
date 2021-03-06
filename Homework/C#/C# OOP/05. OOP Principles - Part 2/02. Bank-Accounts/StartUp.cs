﻿namespace BankAccounts
{
    using BankAccounts.Infrastructure.Enumerations;
    using BankAccounts.Models.Accounts;
    using System;

    class StartUp
    {
        static void Main()
        {
            //Deposit Test
            var depositAccIndividual = new DepositAccount(CustomerType.Individual, 2000.78m, 0.5m);
            Console.WriteLine("Customer: {0} | Balance: ${1:F2} | Interest Amount (12 Months): ${2:F2}",
                depositAccIndividual.Customer, depositAccIndividual.Balance, depositAccIndividual.InterestAmount(12));

            depositAccIndividual.Withdraw(1500);
            Console.WriteLine("Balance after Withdraw: ${0:F2}", depositAccIndividual.Balance);
            Console.WriteLine();

            //Loan Test
            var loanAccCompany = new LoanAccount(CustomerType.Company, 3000000.1234m, 1.0m);
            Console.WriteLine("Customer: {0} | Balance: ${1:F2} | Interest Amount (1 Month): ${2:F2}",
                loanAccCompany.Customer, loanAccCompany.Balance, loanAccCompany.InterestAmount(1));

            loanAccCompany.Deposit(1500000);
            Console.WriteLine("Balance after Deposit: ${0:F2}", loanAccCompany.Balance);
            Console.WriteLine("Interest Amount (13 Months): ${0:F2}", loanAccCompany.InterestAmount(13));
            Console.WriteLine();

            //Mortage Test
            var mortageAccCompany = new MortageAccount(CustomerType.Company, 17000000.98m, 1.5m);
            Console.WriteLine("Customer: {0} | Balance: ${1:F2} | Interest Amount (1 Month): ${2:F2}",
                mortageAccCompany.Customer, mortageAccCompany.Balance, mortageAccCompany.InterestAmount(1));


            var mortageAccIndividual = new MortageAccount(CustomerType.Individual, 105000.13m, 1.0m);
            Console.WriteLine("Customer: {0} | Balance: ${1:F2} | Interest Amount (1 Month): ${2:F2}",
                mortageAccIndividual.Customer, mortageAccIndividual.Balance, mortageAccIndividual.InterestAmount(1));
        }
    }
}
