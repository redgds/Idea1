using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public enum AccountState
    {
        New,
        Active,
        UnderAudit,
        Frozen,
        Closed
    }
}
