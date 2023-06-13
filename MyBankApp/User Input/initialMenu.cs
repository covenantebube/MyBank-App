﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp
{
    public class InitialMenuOptions 
    {
        public static void InitialMenu()
        {
            try
            {
                Console.WriteLine("Welcome To MyBankApp!");

                int initialResponse = 0;

                while (initialResponse > 2 || initialResponse <= 0)
               {
                    Console.WriteLine("Select an Option Below:");
                    Console.WriteLine("1. Existing User? Log In.");
                    Console.WriteLine("2. New User? Create a Customer Account.");
                    initialResponse = int.Parse(Console.ReadLine());
                    Console.Clear();
               }


                if (initialResponse == 1)
                {
                    Console.Clear();
                    Console.WriteLine("login menu");
                 //   LogIn.LogInDetails();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("register menu");
               //     CreateCustomerAccount.RegistrationInfo();
                }


            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Invalid Format!");
                InitialMenu();
            }


        }

    }
}
