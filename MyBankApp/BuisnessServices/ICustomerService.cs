using MyBankApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.BuisnessServices
{
    public interface ICustomerService
    {
        bool CreateCustomer(CustomerAccount customer);

        CustomerAccount? GetCustomerByEmailAndPassword(string email, string password);


        bool AccountCheck(string email, string password);


        CustomerAccount? GetCustomerById(int id);

    }
}
