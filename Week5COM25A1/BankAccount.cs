using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5COM25A1
{
    internal class BankAccount
    {
        private string accountNumber;
        private string accountHolderName;
        private int balance;
        private static int totalAccounts = 0;
        private static double interestRate = 0.1;

        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string AccountHolderName { get => accountHolderName; set => accountHolderName = value; }
        public int Balance { get => balance; set => balance = value; }
        public static int TotalAccounts { get => totalAccounts; set => totalAccounts = value; }
        public static double InterestRate { get => interestRate; set => interestRate = value; }

        public BankAccount(string accountNumber, string accountHolderName, int balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
            totalAccounts++;
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void displayAccountInfo()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder Name: {accountHolderName}");
            Console.WriteLine($"Balance: {balance}");
        }

        public static void setInterestRate(double newRate)
        {
            interestRate = newRate;
        }

        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"Total Accounts: {totalAccounts}");
        }
    }
}
