using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBankApp.Model;

namespace MyBankApp.User_Input
{
    
    
        public class TransactionMenu
        {
         
            public static void TransactionOptions(CustomerAccount customer)
            {
                int option;
                  string fullName = customer.FullName;
                  Console.WriteLine($"Welcome {fullName} to MyBank App");
            do
                {

                    Console.WriteLine("Select an option");
                    Console.WriteLine("Select 1 to Create Bank Account");
                    Console.WriteLine("Select 2 to Deposit");
                    Console.WriteLine("Select 3 to Withdraw");
                    Console.WriteLine("Select 4 to Transfer");
                    Console.WriteLine("Select 5 to Check Balance");
                    Console.WriteLine("Select 6 to Print Account Details");
                    Console.WriteLine("Select 7 Print Account Statement");
                    Console.WriteLine("Select 8 to Log out");
                    option = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                while (option < 0 || option > 8);

                //implement a code to check if user does not have a bank account and chooses option 1-7
                //do this
                 // Console.WriteLine("You dont have a bank Account, Create one first!");
                 // Console.WriteLine("Select 1 to Create Account");
                 //option = int.Parse(Console.ReadLine());
                
                Console.Clear();
                switch (option)
                {
                    case 1:
                    Console.WriteLine("Create new account menu"); ;
                        break;

                    case 2:
                    Console.WriteLine("deposit menu");
                        break;

                    case 3:
                    Console.WriteLine("withdrwal  menu");
                        break;

                    case 4:
                    Console.WriteLine("transfer menu");
                        break;

                    case 5:
                    Console.WriteLine("check balance menu");
                        break;

                    case 6:
                    Console.WriteLine("Print Account Details menu");
                        break;
                    case 7:
                    Console.WriteLine("Print Account Statement menu");
                    break;
                    case 8:
                        InitialMenuOptions.InitialMenu();
                        break;
                }
                Console.WriteLine("Do you want to perform another transaction? ");
                TransactionMenu.TransactionOptions(customer); ;
            }

        }
    
}
