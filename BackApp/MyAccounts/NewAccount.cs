using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.MyAccounts
{
    public class NewAccount : CustomerAccount, IAccount
    {
        public NewAccount(string name, decimal balance) : base(name, balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public new bool WithdrawFunds(decimal amount) // method hiding
        {
            if (amount > 10)
            {
                return false;
            }
            if (balance < amount)
            {
                return false;
            }
            balance -= amount;
            return true;
        }
    }
}
