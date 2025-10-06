using System;
namespace BankingApp
{
    class BankAccount
    {
        private double balance;
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }
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
        public double Balance
        {
            get { return balance; } 
        }
    }
class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1000);

            Console.WriteLine("Balance: " + account.Balance); 
             account.Deposit(500);   
            account.Withdraw(200);  
        }
    }
}
