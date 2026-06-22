using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    internal interface IAccount // interface starts with I
    {
        public bool WithdrawFunds(decimal amount);
        public void PayInFunds(decimal amount);
        public decimal GetBalance();
    }
}

