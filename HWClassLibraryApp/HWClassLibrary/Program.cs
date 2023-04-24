

using ObjectsLibrary.Models;
using System;


List<PersonModel> people = new List<PersonModel>();

PersonModel person = new PersonModel("John", "Wick");
people.Add(person);

person = new PersonModel("John", "Snow");
people.Add(person);

person = new PersonModel("John", "Cena");
people.Add(person);

int count = 1;
Console.WriteLine("Here is our Guests list:");
Console.WriteLine();
foreach (PersonModel p in people)
{
    Console.WriteLine($" {count}. {p.FirstName} {p.LastName}");
    ++count;
}


Console.WriteLine();
Console.WriteLine("End of Program.");
