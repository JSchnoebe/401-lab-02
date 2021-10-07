using System;

namespace ATM
{
    class Program
    {
        private static readonly BankAccount account = new BankAccount();

        static void Main(string[] args)
        {
            WriteWelcome();

            while (true)
            {

                int selected = PromptForAction();

                if (selected == 1)
                {
                    PromptAndDeposit();
                }
                else if (selected == 2)
                {
                    PromptAndWithdraw();
                }
                else if (selected == 3)
                {
                    ViewBalance();
                }
                else if (selected == 4)
                {
                    DisplayTransactionLog();
                }
                else if (selected == 5)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 5.");
                }
            }
        }

        static void WriteWelcome()
        {
            Console.WriteLine("Welcome to your personal ATM!");
        }

        static int PromptForAction()
        {

            Console.WriteLine("Make a selection.");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. View Balance");
            Console.WriteLine("4. Show Transactions");
            Console.WriteLine("5. Exit");

            string input = Console.ReadLine();

            int numInput = Convert.ToInt32(input);

            return numInput;
        }
        
        

        static void PromptAndDeposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            Console.Write("Deposit Amount: ");

            string input = Console.ReadLine();

            decimal numInput = Convert.ToDecimal(input);

            account.Deposit(numInput);

            Console.WriteLine($"{numInput} has been deposited");
        }

        static void PromptAndWithdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            Console.Write("Withdraw Amount: ");

            string input = Console.ReadLine();

            int numInput = Convert.ToInt32(input);

            account.Withdraw(numInput);
        }

        static void ViewBalance()
        {
            decimal balance = account.GetBalance();

            Console.WriteLine($"Your balance is: {balance}");
        }

        static void DisplayTransactionLog()
        {
            string[] logs = account.GetLog();

            for(int i = 0; i < logs.Length; i++)
            {
                Console.WriteLine($"{logs[i]}");
            }
            
        }
    }
}
