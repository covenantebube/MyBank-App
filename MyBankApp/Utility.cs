using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp
{
    public static class Utility
    {
        
            public static string HidePassword()
            {
                string? password = "";
                ConsoleKeyInfo keyInfo;

                do
                {
                    keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key != ConsoleKey.Enter)
                    {
                        password += keyInfo.KeyChar;
                        Console.Write("*");
                    }
                } while (keyInfo.Key != ConsoleKey.Enter);

                Console.WriteLine();

                return password;
            }
        

    }
}
