

using MethodsAndTuples;

//(string , string) fullName = ConsoleMessages.GetFullName();
//var fullName = ConsoleMessages.GetFullName();

//Console.WriteLine($"Your first name is {fullName.Item1}.");
//Console.WriteLine($"Your last name is {fullName.Item2}.");


//(string firstName, string lastName) fullName = ConsoleMessages.GetFullName();

//Console.WriteLine($"Your first name is {fullName.firstName}.");
//Console.WriteLine($"Your last name is {fullName.lastName}.");


//(string firstName, string lastName) = ConsoleMessages.GetFullName();
//var (firstName, lastName) = ConsoleMessages.GetFullName();

//Console.WriteLine($"Your first name is {firstName}.");
//Console.WriteLine($"Your last name is {lastName}.");


// Discard character '_'
(string firstName, _) = ConsoleMessages.GetFullName();

Console.WriteLine($"Only need your first name, which is {firstName}.");
