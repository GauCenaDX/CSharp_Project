
namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have been using Generics without knowing about it
            // List<T>

            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();

            stringList.Add("Test");
            //stringList.Add(1);  //-- Can't do that
            stringList.Add(1.ToString());

            intList.Add(1);
            //intList.Add("Test");  //-- Can't do that


            // Using our generic FizzBuzz method
            string result = FizzBuzz("tests");
            Console.WriteLine($"tests: {result}");

            result = FizzBuzz(123);
            Console.WriteLine($"123: {result}");

            result = FizzBuzz(true);
            Console.WriteLine($"true: {result}");

            // GenericsDemo.PersonModel == 24
            result = FizzBuzz(new PersonModel { FirstName = "Eren", LastName = "Yeager" });
            Console.WriteLine($"PersonModel: {result}");
            Console.WriteLine();


            // Using our generic GenericHelper class
            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "Miyo", HasError = true });

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} was rejected.");
            }


            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }

        // Number divisible by - print out this word
        // 3 - Fizz, 5 - Buzz, both - FizzBuzz
        private static string FizzBuzz<T>(T item)
        {
            int itemLength = item.ToString().Length;
            string output = "";

            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }

            return output;
        }
    }

    public interface IErrorCheck
    {
        bool HasError { get; set; }
    }

    public class GenericHelper<T> where T: IErrorCheck
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();

        public void CheckItemAndAdd(T item)
        {
            if (item.HasError == false)
            {
                Items.Add(item);
            }
            else
            {
                RejectedItems.Add(item);
            }
        }
    }

    public class PersonModel : IErrorCheck
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasError { get; set; }

    }
}
