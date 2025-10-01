using System;

namespace BankingApp
{
    class BankAccount
    {
        // private field (cannot be accessed directly)
        private double balance;

        // constructor to set initial balance
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        // public method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount}. New Balance = {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // public method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New Balance = {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount.");
            }
        }

        // read-only property to check balance
        public double Balance
        {
            get { return balance; } // only allows reading, not direct setting
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1000);

            Console.WriteLine("Balance: " + account.Balance); // ✅ Allowed

            account.Deposit(500);   // ✅ Works
            account.Withdraw(200);  // ✅ Works

            // account.balance = 99999; // ❌ Error: balance is private (not accessible)
        }
    }
}
