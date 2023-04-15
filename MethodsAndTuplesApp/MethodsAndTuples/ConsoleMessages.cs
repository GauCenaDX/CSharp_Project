

using System;

namespace MethodsAndTuples
{
    public static class ConsoleMessages
    {
        // Tuple
        //public static (string, string) GetFullName()
        public static (string firstName, string lastName) GetFullName()
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            return (firstName, lastName);
        }
    }
}