using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.MyAccounts
{
    public class CustomerAccount : IAccount
    {
        private decimal balance = 0;

        public bool WithdrawFunds(decimal amount)
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
        public decimal GetBalance() { return balance; }
    }
}
