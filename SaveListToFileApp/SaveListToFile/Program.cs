
//using Microsoft.VisualBasic;
using System.IO;

namespace SaveListToFile
{
    // Take a list of objects and save it into a CSV file (comma delimited).
    //   - Generics: create a SaveToCSV method that take in any object
    //   - Events: detect and shout out when people try to use bad words

    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{ FirstName = "Kiroto", LastName = "Kazutodarnit", Email = "kirito@blackswordman.com"},
                new PersonModel{ FirstName = "Asuna", LastName = "Yuki", Email = "asuna@theflash.com"},
                new PersonModel{ FirstName = "Yuuki", LastName = "Konno", Email = "Yuuki@sleepingknight.com"}
            };

            List<CarModel> cars = new List<CarModel>
            {
                new CarModel{ Manufacturer = "Toyota", Model = "DARNCorolla"},
                new CarModel{ Manufacturer = "Toyota", Model = "Rav4"},
                new CarModel{ Manufacturer = "Chevrolet", Model = "heckCamaro" }
            };

            DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
            peopleData.BadEntryFound += PeopleData_BadEntryFound;

            peopleData.SaveToCSV(people, "/tmp/people.csv");

            DataAccess<CarModel> carData = new DataAccess<CarModel>();
            carData.BadEntryFound += CarData_BadEntryFound;

            carData.SaveToCSV(cars, "/tmp/cars.csv");


            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }

        private static void CarData_BadEntryFound(object? sender, CarModel e)
        {
            Console.WriteLine($"Bad Entry found for {e.Manufacturer} {e.Model}");
        }

        private static void PeopleData_BadEntryFound(object? sender, PersonModel e)
        {
            Console.WriteLine($"Bad Entry found for {e.FirstName} {e.LastName}");
        }
    }
}
