using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.MyAccounts
{
    public sealed class BabyAccount : CustomerAccount, IAccount
    {
        //private decimal balance = 0;
        public BabyAccount()
        {

        }
        public BabyAccount(string name, decimal balance) : base(name, balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public override bool WithdrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }
            //if (balance < amount)
            //{
            //    return false;
            //}
            //balance -= amount;
            //return true;
            return base.WithdrawFunds(amount);
        }

        //public void PayInFunds(decimal amount)
        //{
        //    balance += amount;
        //}
        //public decimal GetBalance() { return balance; }
    }
}