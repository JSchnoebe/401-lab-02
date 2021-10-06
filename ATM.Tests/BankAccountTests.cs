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

            Assert.Equal(10, result);
        }

        [Fact]
        public void Withdraw()
        {
            BankAccount ba = new BankAccount();

            ba.Deposit(10);

            ba.Withdraw(5);

            decimal result = ba.GetBalance();

            Assert.Equal(5, result);
        }

        [Fact]
        public void Deposit_Throws_For_Negative_Value()
        {
            //Arrange
            BankAccount ba = new BankAccount();

            ba.Deposit(10);

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {

                //Act
                ba.Withdraw(15);

            });
        }

        [Fact]
        public void Deposits_Negative_Amount()
        {
            //Arrange
            BankAccount ba = new BankAccount();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {

                //Act
                ba.Deposit(-10);

            });
        }

        [Fact]
        public void Withdraws_Negative_Amount()
        {
            //Arrange
            BankAccount ba = new BankAccount();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {

                //Act
                ba.Withdraw(-10);

            });
        }
    }
}
