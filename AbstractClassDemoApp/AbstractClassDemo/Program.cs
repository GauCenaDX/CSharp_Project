
namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // It makes sense to instantiate a book
            Book book = new Book();
            book.ProductName = "A Tales of Two Cities";

            // It doesn't make sense to instantiate an Inventory Item,
            // so let make it an abstract class
            //InventoryItem item = new InventoryItem();
            //item.ProductName = "What item?";

            // We can still do this
            InventoryItem anotherBook = new Book();


            Car car = new Car();
            car.VIN = "M4K007";
            car.Manufacturer = "Toyota";
            car.Model = "Corolla Apex";
            car.YearManufactured = 2023;

            Console.WriteLine("My car info:");
            Console.WriteLine($"- VIN: {car.VIN}");
            Console.WriteLine($"- Manufacturer: {car.Manufacturer}");
            Console.WriteLine($"- Model: {car.Model}");
            Console.WriteLine($"- Year: {car.YearManufactured}");
            Console.WriteLine($"- Number of Wheels: {car.NumberOfWheels}");


            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }
}

