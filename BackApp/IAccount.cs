using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    interface IAccount // interface starts with I
    {
        bool WithdrawFunds(decimal amount);
        void PayInFunds(decimal amount);
        decimal GetBalance();
    }
}

