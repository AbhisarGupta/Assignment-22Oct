using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Account
    {
        int[] accountNumber= new int[5];
        string[] customerName = new string[30];
        string[] accountType = new string[];
        string[] transType = new string[] { "Deposit", "Withdrawal" };
        int amount = 0;
        int balance = 0;

        public int credit(int amount)
        {
            balance += amount;
            return balance;
        }

        public int debit(int amount)
        {
            balance -= amount;
            return balance;
        }

        public void accept()
        {
            Console.WriteLine("enter account number:\t");
            accountNumber[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("enter name:\t");
            customerName[0]

        }
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
        }
    }
}
