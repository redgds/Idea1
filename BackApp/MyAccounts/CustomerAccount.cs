using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.MyAccounts
{
    public class CustomerAccount : IAccount
    {
        protected decimal balance = 0;
        protected string name { get; set; } = string.Empty;
        // private decimal balance = 0;

        public CustomerAccount() { }
        public CustomerAccount(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public virtual bool WithdrawFunds(decimal amount)
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
