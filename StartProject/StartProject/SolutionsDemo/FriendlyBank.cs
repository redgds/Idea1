using System;
using System.Collections.Generic;
using System.Text;

namespace Idea1.SolutionsDemo
{

    internal class FriendlyBank
    {
        enum AccountState
        {
            New,
            Active,
            UnderAudit,
            Frozen,
            Closed
        };

        const int MAX_CUST = 50;


        AccountState[] states = new AccountState[MAX_CUST];
        string[] names = new string[MAX_CUST];
        string[] addresses = new string[MAX_CUST];
        int[] accountNos = new int[MAX_CUST];
        int[] balances = new int[MAX_CUST];
        int[] overdraft = new int[MAX_CUST];


        struct Account
        {
            public AccountState State;
            public string Name;
            public string Address;
            public int AccountNo;
            public int Balance;
            public int Overdraft;

        }


        public static void Main()
        {
            Account MyAccount = new Account();
            MyAccount.State = AccountState.Active;
            MyAccount.Balance = 0;

            Account[] Bank = new Account[MAX_CUST];
            Bank[0] = MyAccount;

            Bank[1].Name = "Jim";
            Bank[1].State = AccountState.Frozen;
            Bank[1].Balance = 0;
        }


    }

}
