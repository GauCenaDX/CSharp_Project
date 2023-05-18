
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "What is your first name: ".RequestString();
            person.LastName = "What is your last name: ".RequestString();
            person.Age = "What is your age: ".RequestInt(0, 120);
            //person.Age = ConsoleHelper.RequestInt("What is your age: ", 0, 120);

            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }
}
