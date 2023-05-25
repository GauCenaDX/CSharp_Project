
//using Microsoft.VisualBasic;
using System.IO;

namespace SaveListToFile
{
    // Take a list of objects and save it into a CSV file (comma delimited).
    //   - Generics: 
    //   - Events: detect and shout out when people try to use bad words

    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{ FirstName = "Kiroto", LastName = "Kazuto", Email = "kirito@blackswordman.com"},
                new PersonModel{ FirstName = "Asuna", LastName = "Yuki", Email = "asuna@theflash.com"},
                new PersonModel{ FirstName = "Yuuki", LastName = "Konno", Email = "Yuuki@sleepingknight.com"}
            };

            List<CarModel> cars = new List<CarModel>
            {
                new CarModel{ Manufacturer = "Toyota", Model = "Corolla"},
                new CarModel{ Manufacturer = "Toyota", Model = "Rav4"},
                new CarModel{ Manufacturer = "Chevrolet", Model = "Camaro" }
            };

            //people.SaveToCSV(@"C:\Temp\SavedFiles\people.csv");  //-- For Windows
            people.SaveToCSV("/tmp/people.csv");
            cars.SaveToCSV("/tmp/cars.csv");

            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }

    public static class DataAccess
    {
        // Create a Generic Extension method
        public static void SaveToCSV<T>(this List<T> items, string filePath) where T : new()
        {
            List<string> rows = new List<string>();
            T entry = new T();
            // Get the type of objects it is and get the list of properties that
            // are on that type.
            // Introduction to reflection: System.Reflection.Property
            var cols = entry.GetType().GetProperties();

            // Add the Header row
            string row = "";
            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1);  //-- Example: FirstName,LastName,Email
            rows.Add(row);

            // Add the value rows
            foreach (var item in items)
            {
                row = "";
                foreach (var col in cols)
                {
                    row += $",{col.GetValue(item, null)}";
                }
                row = row.Substring(1);
                rows.Add(row);
            }

            //File.WriteAllLines(string path, IEnumerable<string> contents)
            File.WriteAllLines(filePath, rows);
        }
    }
}
