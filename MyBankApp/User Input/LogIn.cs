﻿using MyBankApp.BuisnessServices;
using MyBankApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.User_Input
{
        public class LogIn
        {
        private static ICustomerService _customerService;
        public static ICustomerService customerService
        {
            get => _customerService ??= new CustomerService();
        }

        public static void LogInDetails()
            {
                Console.Write("Enter email address? ");
                string? email = Console.ReadLine();
                Console.Write("Password? ");
                string? password = Console.ReadLine();

            while (!customerService.AccountCheck(email, password))
            {
                Console.Clear();
                Console.WriteLine("User not Found, Enter an  existing email and Password.");
                LogInDetails();
            }


            CustomerAccount? customer = customerService.GetCustomerByEmailAndPassword(email, password);
            Console.ReadLine();
            Console.Clear();
            TransactionMenu.TransactionOptions(customer);

            }


        }
    

}
