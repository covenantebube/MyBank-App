using MyBankApp.Model;
using MyBankApp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.BuisnessServices
{

    public class BankAccountService : IBankAccountService
    {
        void IBankAccountService.CheckBalance(string accountNumber)
        {
            throw new NotImplementedException();
        }

        bool IBankAccountService.CheckBankAccountByAccountNumber(string accountNumber)
        {
            throw new NotImplementedException();
        }

        bool IBankAccountService.CheckBankIdByCustomerId(int id)
        {
            throw new NotImplementedException();
        }

        bool IBankAccountService.CreateBankAccount(BankAccount bankAccount)
        {
            throw new NotImplementedException();
        }

        bool IBankAccountService.Deposit(decimal amount, BankAccount bankAccount, string note)
        {
            throw new NotImplementedException();
        }

        List<BankAccount>? IBankAccountService.GetAllAccountsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        BankAccount? IBankAccountService.GetBankAccountByCustomerId(int id)
        {
            throw new NotImplementedException();
        }

        BankAccount? IBankAccountService.GetBankAccountsByAccountNumber(string accountNumber)
        {
            throw new NotImplementedException();
        }

        void IBankAccountService.PrintAccountDetails(int customerId)
        {
            throw new NotImplementedException();
        }

        void IBankAccountService.PrintAccountStatement(BankAccount bankAccount)
        {
            throw new NotImplementedException();
        }

        bool IBankAccountService.Transfer(decimal amount, BankAccount bankAccount, string note, string DestinationAccount)
        {
            throw new NotImplementedException();
        }

        bool IBankAccountService.Withdraw(decimal amount, BankAccount bankAccount, string note)
        {
            throw new NotImplementedException();
        }
    }
}