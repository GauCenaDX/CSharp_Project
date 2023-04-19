

using HWInstantiatedClasses;

Console.WriteLine("Welcome to our Digital Contact Book!!!");

Console.WriteLine();
Console.Write("Do you want to add a new contact? (yes/no) ");
string userInput = Console.ReadLine();

List<PersonModel> people = new List<PersonModel>();

while (userInput.ToLower() != "no")
{
    PersonModel person = new PersonModel();

    GetInfo.GetContactInfo(person);

    people.Add(person);

    Console.WriteLine();
    Console.Write("Do you want to add a new contact? (yes/no) ");
    userInput = Console.ReadLine();
}

Console.Clear();
Console.WriteLine("Your contact list:");
Console.WriteLine("------------------");
foreach (PersonModel p in people)
{
    Console.WriteLine();
    Console.WriteLine($"Name: {p.FirstName} {p.LastName}");
    Console.WriteLine($"Email: {p.EmailAddress}");
    Console.WriteLine($"Address: {p.Address.AddressLine}, {p.Address.City}, " +
        $"{p.Address.State} {p.Address.ZipCode}");
}

Console.WriteLine();
Console.WriteLine("End of program.");
