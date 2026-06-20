using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    internal class StructTest
    {
        // Define a struct to hold the data for each customer
        public struct Account
        {
            public AccountState State;
            public string Name;
            public string Address;
            public int AccountNo;
            public int Balance;
            public int Overdraft;
        }

        static int MAX_CUST = 50;

        // Arrays to hold the data for each customer
        AccountState[] states = new AccountState[MAX_CUST];
        private static string[] names = new string[MAX_CUST];
        private static string[] addresses = new string[MAX_CUST];
        private static int[] accountNos = new int[MAX_CUST];
        private static int[] balances = new int[MAX_CUST];
        private static int[] overdraft = new int[MAX_CUST];

        public static void PrintAccout(Account a)
        {
            Console.WriteLine("Account Name: " + a.Name);
            Console.WriteLine("Account State: " + a.Address);
            Console.WriteLine("Account Balance: " + a.Balance);
        }
    }
}
