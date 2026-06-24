using BankApp;
using BankApp.MyAccounts;
using System;
using System.Collections;
const int MAX_CUST = 100;

//StructTest.StructUse();

//AccountTest.NewAccount();

//AccountTest.TestWithdrawFunds(AccountTest.RobsAccount);

//AccountTest.TestPayInFunds(AccountTest.RobsAccount);

//AccountTest.TestAccountAllowed(AccountTest.RobsAccount);


//Account[] Accounts = new Account[MAX_CUST];
//Accounts[0] = AccountTest.RobsAccount;
//Accounts[1] = new Account("Jim", "Jim's House");
//Accounts[2] = new Account("Fred");

IAccount[] accounts = new IAccount[MAX_CUST];

accounts[0] = new CustomerAccount();
accounts[0].PayInFunds(100);
Console.WriteLine($"Balance for account 0: {accounts[0].GetBalance()}");

accounts[1] = new BabyAccount();
accounts[1].PayInFunds(20);
Console.WriteLine($"Balance for account 1: {accounts[1].GetBalance()}");

if (accounts[0].WithdrawFunds(20))
{
    Console.WriteLine("Withdraw OK");
}

if (accounts[1].WithdrawFunds(20))
{
    Console.WriteLine("Withdraw OK"); // will not execute
}

NewAccount MyAcc = new("Rob Miles", 100);