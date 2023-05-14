
using MethodOverridingDemo.Person;
using MethodOverridingDemo.Car;

namespace MethodOverridingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Mikasa",
                LastName = "Ackerman",
                Email = "mikasa.ackerman@attackontitan.manga"
            };

            // namespace.classname - full path to class
            // MethodOverridingDemo.PersonModel
            Console.WriteLine(person);
            //Console.WriteLine(person.ToString());



            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }
}
