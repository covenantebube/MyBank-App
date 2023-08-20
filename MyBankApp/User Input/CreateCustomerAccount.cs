
using MyBankApp.BuisnessServices;
using MyBankApp.Model;
using MyBankApp.User_Input;

namespace MyBankApp
{
    public class CreateCustomerAccount
    {
        private static ICustomerService _customerService;
        public static ICustomerService customerService
        {
            get => _customerService ??= new CustomerService();
        }
        public static void RegistrationInfo()
        {
            //Enter your first name
            Console.Write("First Name? ");
            string? firstname = Console.ReadLine();

            while (!Validate.IsValidName(firstname))
            {
                Console.Clear();
                Console.Write("Invalid Entry, Name must begin with capital letters! \n First Name? ");
                firstname = Console.ReadLine();
            }
            //Enter your last name
            Console.Write("Last Name? ");
            string? lastname = Console.ReadLine();
            while (!Validate.IsValidName(lastname))
            {
                Console.Clear();
                Console.Write("Invalid Entry, Name must begin with capital letters! \nLast Name ? ");
                lastname = Console.ReadLine();
            }

            //Enter your email address
            Console.Write("Email Address? ");
            string? emailaddress = Console.ReadLine();
            while (!Validate.IsValidEmail(emailaddress))
            {
                Console.Clear();
                Console.Write("Invalid Entry! Email Address? ");
                emailaddress = Console.ReadLine();
            }
            //Enter your password
            Console.Write("Password? ");
            string? password = Utility.HidePassword();
            while (!Validate.IsValidPassword(password))
            {
                Console.Clear();
                Console.Write("Password should contain minimum of 6 alphanumeric and special characters! \n Password? ");
                password = Utility.HidePassword();
            }


            if (customerService.AccountCheck(emailaddress, password))
            {
                Console.WriteLine("Account already exists");
                Console.ReadLine();
                Console.Clear();
                InitialMenuOptions.InitialMenu();
            }
            else
            {

                string fullname = firstname + " " + lastname;
                CustomerAccount customer = new(fullname, emailaddress, password);
                Console.WriteLine($"Congratulations {fullname}, Your Savings Account has been created");
                Console.ReadLine();
                Console.Clear();
                TransactionMenu.TransactionOptions(customer);

            }
        }

    }
}
