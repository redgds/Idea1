using System;
namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_CUST = 100;
            StructTest.Account[] Bank = new StructTest.Account[MAX_CUST];
            Bank[0] = new StructTest.Account { Name = "Rob", Address = "Rob's House", State = AccountState.Active, Balance = 0 };
            StructTest.PrintAccout(Bank[0]);

            Bank[1].Name = "Jim";
            Bank[1].Address = "Jim's House";
            Bank[1].State = AccountState.Active;
            Bank[1].Balance = 0;
            StructTest.PrintAccout(Bank[1]);

            ClassTest RobsAccount = new()
            {
                Name = "Rob",
                // Balance = 0 // unaccessible because Balance is private
            };
            Console.WriteLine(RobsAccount.Name); // Rob


            //ClassTest Temp = RobsAccount;

            //Temp.Name = "Jim";
            //Console.WriteLine(Temp.Name); // Jim
            //Console.WriteLine(RobsAccount.Name); // Jim

            //RobsAccount = new ClassTest
            //{
            //    Name = "Jim" // This is a new instance of ClassTest, so it does not affect the previous instance
            //}; 
            //Console.WriteLine(RobsAccount.Name);


            // RobsAccount.Balance = 0; // unaccessible because Balance is private


            if (RobsAccount.WithdrawFunds(5))
            {
                Console.WriteLine("Withdrawal successful");
            }
            else
            {
                Console.WriteLine("Withdrawal failed");
        }
        }
    }
}