﻿using System;
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
            }
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > balance)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                balance = balance - amountToWithdraw;
            }
        }
    }
}
