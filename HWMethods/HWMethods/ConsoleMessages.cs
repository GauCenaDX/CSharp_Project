using System;

namespace Methods
{
    public static class ConsoleMessages
    {

        public static void Welcome()
        {
            Console.WriteLine("Welcome to our program!");
        }

        public static string GetUserName()
        {
            Console.Write("Please tell us your first name: ");
            string firstName = Console.ReadLine();

            return firstName;
        }

        public static void Greeting(string firstName)
        {
            Console.WriteLine($"Hello {firstName}.");
        }
    }
}