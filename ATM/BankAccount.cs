using System;
namespace ATM
{
    public class BankAccount
    {
        private decimal balance;

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amountToDeposit)
        {
            balance = balance + amountToDeposit;
        }

    }
}
