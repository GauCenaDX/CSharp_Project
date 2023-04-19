
using ConsoleUI;

//List<PersonModel> people = new List<PersonModel>();

//// Build a house from the blueprint
//PersonModel person = new PersonModel();
//person.firstName = "Tim";
//people.Add(person);

//// Each instance is a variable that holds the street address
//person = new PersonModel();
//person.firstName = "Sue";
//people.Add(person);

//foreach (PersonModel p in people)
//{
//    Console.WriteLine(p.firstName);
//}


List<PersonModel> people = new List<PersonModel>();
string firstName = "";

do
{
    Console.Write("What is your first name (or type exit to stop): ");
    firstName = Console.ReadLine();

    Console.Write("What is your last name: ");
    string lastName = Console.ReadLine();

    if (firstName.ToLower() != "exit")
    {
        PersonModel person = new PersonModel();
        person.FirstName = firstName;
        person.LastName = lastName;
        people.Add(person);
    }
} while (firstName.ToLower() != "exit");

// Put a breakpoint here and observe the value of people
foreach (PersonModel p in people)
{
    ProcessPerson.GreetPerson(p);
}

Console.WriteLine("End of Program.");
