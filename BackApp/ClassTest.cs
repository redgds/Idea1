using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    internal class ClassTest
    {
        public string Name;

        private decimal Balance;

        public bool WithdrawFunds ( decimal amount)
        {
            if (Balance < amount)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
    }
}
