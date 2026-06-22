using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.MyAccounts
{
    public class BabyAccount : IAccount
    {
        private decimal balance = 0;

        public bool WithdrawFunds(decimal amount)
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
        public void PayInFunds(decimal amount)
        {
            balance += amount;
        }
        public decimal GetBalance() { return balance; }
    }
}