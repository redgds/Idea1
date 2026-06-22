using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    internal class AccountTest
    {
        public static Account RobsAccount = new("Rob", "Rob's House", 0);
        public static void NewAccount()
        {
            Account RobsAccount = new()
            {
                Name = "Rob",
                // Balance = 0 // unaccessible because Balance is private
            };
            Console.WriteLine(RobsAccount.Name); // Rob
        }

        public static void TestWithdrawFunds(Account RobsAccount)
        {
            if (RobsAccount.WithdrawFunds(5))
            {
                Console.WriteLine("Withdrawal successful");
            }
            else
            {
                Console.WriteLine("Withdrawal failed");
            }
        }

        public static void TestPayInFunds(Account RobsAccount)
        {
            RobsAccount.PayInFunds(50);
            if (RobsAccount.GetBalance() != 50)
            {
                Console.WriteLine("Pay In test failed");
            }
            else
            {
                Console.WriteLine("Pay In test succeeded");
            }
        }

        public static void TestAccountAllowed(Account RobsAccount)
        {
            if (Account.AccountAllowed(25000, 21))
            {
                Console.WriteLine("Allowed Account");
            }
        }
    }
}
