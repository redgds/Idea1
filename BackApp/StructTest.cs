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

        public static void StructUse()
        {
            StructTest.Account[] Bank = new StructTest.Account[MAX_CUST];
            Bank[0] = new StructTest.Account { Name = "Rob", Address = "Rob's House", State = AccountState.Active, Balance = 0 };
            StructTest.PrintAccout(Bank[0]);

            Bank[1].Name = "Jim";
            Bank[1].Address = "Jim's House";
            Bank[1].State = AccountState.Active;
            Bank[1].Balance = 0;
            StructTest.PrintAccout(Bank[1]);
        }
    }
}
