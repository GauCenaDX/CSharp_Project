

using System;

namespace ConsoleUI
{
    public static class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            // Clear out the text in the terminal/console
            Console.Clear();
            Console.WriteLine("Welcome to the Static Class Demo App.");

            // 0 - 23
            int hourOfDate = DateTime.Now.Hour;

            if (hourOfDate < 12)
            {
                Console.WriteLine($"Good morning {firstName}!");
            }
            else if (hourOfDate < 19)
            {
                Console.WriteLine($"Good afternoon {firstName}!");
            }
            else
            {
                Console.WriteLine($"Good evening {firstName}!");
            }
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();

            Console.WriteLine("Thank you for using our app to calculate for you.");
        }
    }
}