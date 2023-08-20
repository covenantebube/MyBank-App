using MyBankApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.BuisnessServices
{
    public interface IBankAccountService
    {
        bool CreateBankAccount(BankAccount bankAccount);


        BankAccount? GetBankAccountByCustomerId(int id);

        bool CheckBankIdByCustomerId(int id);

        bool CheckBankAccountByAccountNumber(string accountNumber);

        List<BankAccount>? GetAllAccountsByCustomerId(int customerId);

        BankAccount? GetBankAccountsByAccountNumber(string accountNumber);

        void CheckBalance(string accountNumber);

        bool Deposit(decimal amount, BankAccount bankAccount, string note);

        bool Withdraw(decimal amount, BankAccount bankAccount, string note);

        bool Transfer(decimal amount, BankAccount bankAccount, string note, string DestinationAccount);

        void PrintAccountDetails(int customerId);

        void PrintAccountStatement(BankAccount bankAccount);

    }
}
