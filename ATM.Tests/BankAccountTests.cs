using System;
using Xunit;

namespace ATM.Tests
{
    public class BankAccountTests
    {
        [Fact]
        public void Account_Starts_With_No_Money()
        {
            //Arrange
            BankAccount ba = new BankAccount();

            //Act
            decimal result = ba.GetBalance();

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Deposit()
        {
            BankAccount ba = new BankAccount();
            ba.Deposit(10);

            decimal result = ba.GetBalance();

            Assert.Equal(0, result);
        }
    }
}
