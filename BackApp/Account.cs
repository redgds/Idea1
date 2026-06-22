using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BankApp
{
    internal class Account
    {
        public string Name;

        private string name;
        private string address;
        private decimal balance; // private field is camelCase

        public static decimal InterestRateCharged;


        private static decimal minIncome = 10000;
        private static int minAge = 18;


        public Account()
        {
           Console.WriteLine("Account created"); // will be called when an instance of the class is created
        
        }
        public Account(string name, string address, decimal balance) // public constructor is PascalCase
        {
            this.name = name;
            this.address = address;
            this.balance = balance;
        }

        public Account(string name, string address):
            this(name, address, 0) // constructor chaining
        {
        }
        
        public Account(string name) :
            this(name, "Unknown", 0) // constructor chaining
        {
        }


        public bool WithdrawFunds ( decimal amount) // public method is PascalCase
        {
            if (balance < amount)
            {
                return false;
            }
            else
            {
                balance -= amount;
                return true;
            }
        }


        public void PayInFunds(decimal amount)
        {
            balance += amount;
        }
        public decimal GetBalance()
        {
            return balance;
        }


        public static bool AccountAllowed(decimal income, int age)
        {
            return income >= minIncome && age >= minAge;
        }
    }
}
