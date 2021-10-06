using System;
using System.IO;
namespace ATM
{
    public class BankAccount
    {
        private decimal balance = 0;

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amountToDeposit)
        {
            if (amountToDeposit <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                balance = balance + amountToDeposit;
                WriteToLog(amountToDeposit);
            }
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > balance || amountToWithdraw < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                balance = balance - amountToWithdraw;
                WriteToLog(amountToWithdraw);
            }
        }

        private void WriteToLog(decimal input)
        {
            string logMessage = $"{DateTime.Today:yyyy-MM-dd}: {input} {balance}\n";
            File.AppendAllText("transaction-log.txt", logMessage);
        }

        public string[] GetLog()
        {
            string[] transactions = File.ReadAllLines("transaction-log.txt");

            return transactions;
            
        }
    }
}
