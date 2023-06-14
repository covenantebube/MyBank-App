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
           
            public static void LogInDetails()
            {
                Console.Write("Enter email address? ");
                string? email = Console.ReadLine();
                Console.Write("Password? ");
                string? password = Console.ReadLine();

            //implement a code that uses the email and password to checks if account exist, if it doesn't exist then
            //    Console.Clear();
            //    Console.WriteLine("User not Found, Enter an  existing email and Password.");
            //    LogInDetails();

            //find the customer(user) using the input email and password
            
            //  temporal  
            string fullname = "Covenant Innocent";
            CustomerAccount customer = new(fullname, email, password);

           
            Console.Clear();
            TransactionMenu.TransactionOptions(customer);

            }


        }
    

}
