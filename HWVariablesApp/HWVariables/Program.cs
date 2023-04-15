

// - A console application
// - Variables for:
//     ○ person's name
//     ○ age
//     ○ if they are alive
//     ○ phone number
// - Note: do not need to capture these values from users

string? name = null;
int? age = null;
bool? isAlive = null;
string? phone = null;

name = "John Wick";
age = 53;
isAlive = true;
phone = "(916) 399 1574";

Console.WriteLine("Client information");
Console.WriteLine("------------------");
Console.WriteLine();
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Still Alive: {isAlive}");
Console.WriteLine($"Phone: {phone}");

Console.ReadLine();
