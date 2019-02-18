using System;

namespace Autotenfication
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string password = "hello@123";
            string loginInput;
            string passwordInput;
            int counter = 3;

            while (counter > 0)
            {
                Console.WriteLine("Login:");
                loginInput = Console.ReadLine();
                Console.WriteLine("Password:");
                passwordInput = Console.ReadLine();

                if (loginInput == login && passwordInput == password)
                {
                    Console.WriteLine("Successful Autotenfication!");
                    counter = 0;
                }
                else
                {
                    Console.WriteLine("Wrong login or password! {0} attempts left.", --counter);
                }

                Console.ReadKey();
            }
        }
    }
}
