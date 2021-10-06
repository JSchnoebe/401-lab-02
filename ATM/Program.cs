using System;

namespace ATM
{
    class Program
    {
        private static readonly BankAccount account;

        static void Main(string[] args)
        {
            WriteWelcome();

            int selected = PromptForAction();

            if (selected == 1)
            {
                PromptAndDeposit();
            }
            else if (selected == 2)
            {
                PromptAndWithdraw();
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
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            int numInput = Convert.ToInt32(input);

            return numInput;
        }
        
        

        static void PromptAndDeposit()
        {
            Console.WriteLine("How much would you like to deposit?");

            string input = Console.ReadLine();

            int numInput = Convert.ToInt32(input);

            account.Deposit(numInput);
        }

        static void PromptAndWithdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");

            string input = Console.ReadLine();

            int numInput = Convert.ToInt32(input);
        }
    }
}
