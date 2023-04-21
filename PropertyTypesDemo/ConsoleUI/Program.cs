

using ConsoleUI;

PersonModel person = new PersonModel("Hamachi");

person.FirstName = "Tom";
//person.LastName = "Cruise";
person.Age = 40;
person.SSN = "242-45-9075";

//Console.WriteLine($"{person.FirstName} {person.LastName}");
Console.WriteLine(person.Age);
Console.WriteLine(person.SSN);

Console.WriteLine(person.FullName);

Console.WriteLine();
Console.WriteLine("End of Program.");
