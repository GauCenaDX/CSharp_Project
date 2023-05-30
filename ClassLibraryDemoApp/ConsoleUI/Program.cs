
//using FrameworkLibrary;
//using CoreLibrary;
using StandardLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Generators generators = new Generators();
            PersonModel person = new PersonModel
            {
                Prefix = "Mr.",
                FirstName = "John",
                LastName = "Snow"
            };

            string message = generators.WelcomeMessage(person.Prefix, person.LastName);
            Console.WriteLine(message);

            Console.WriteLine();
            message = generators.FarewellMessage(person.Prefix, person.LastName);
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
