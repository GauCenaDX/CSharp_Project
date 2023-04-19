

using System;

namespace HWInstantiatedClasses
{
    public static class GetInfo
    {
        public static void GetContactInfo(PersonModel person)
        {
            Console.WriteLine();
            Console.Write("Enter first name: ");
            string userInput = Console.ReadLine();
            person.FirstName = userInput;

            Console.Write("Enter last name: ");
            userInput = Console.ReadLine();
            person.LastName = userInput;

            Console.Write("Enter email address: ");
            userInput = Console.ReadLine();
            person.EmailAddress = userInput;

            AddressModel address = new AddressModel();

            Console.WriteLine("Enter contact address: ");
            Console.Write("  - Address line: ");
            userInput = Console.ReadLine();
            address.AddressLine = userInput;

            Console.Write("  - City: ");
            userInput = Console.ReadLine();
            address.City = userInput;

            Console.Write("  - State: ");
            userInput = Console.ReadLine();
            address.State = userInput;

            Console.Write("  - Zip code: ");
            userInput = Console.ReadLine();
            address.ZipCode = userInput;

            person.Address = address;
        }
    }
}