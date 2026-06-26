using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.PropertyTest
{
    internal class Properties : IProperty
    {
        public int Age
        {
            set
            {
                if ((value > 0) && (value < 100)) {
                    field = value;
                }
            }
            get;
        }
    }
}
