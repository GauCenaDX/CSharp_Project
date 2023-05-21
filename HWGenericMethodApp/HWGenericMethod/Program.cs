
namespace HWGenericMethod
{
    // Create a generic method that takes in an item and calls the ToString()
    // method and prints that value to the Console.

    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            string aString = "This is a string";
            double aDouble = 27.9;
            object anObject = new object();

            CallToString(isTrue);
            CallToString(aString);
            CallToString(aDouble);
            CallToString(anObject);


            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }

        private static void CallToString<T>(T item)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
