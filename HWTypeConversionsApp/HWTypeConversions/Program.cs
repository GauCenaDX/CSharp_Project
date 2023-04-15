

// - Capture user's age from console
// - Identify their age in 25 years
// - Identify their age 25 years ago
// - Print the info to console in natural language

string? ageText;
int age;

Console.Write("Please enter your current age: ");
ageText = Console.ReadLine();

bool isValidInt = int.TryParse(ageText, out age);

Console.WriteLine($"The age entered is: {ageText}.");
Console.WriteLine($"It is valid: {isValidInt}. So we use {age} as your current age.");
Console.WriteLine($"Your age in 25 year is: {age + 25}.");
Console.WriteLine($"Your age 25 years ago was: {age - 25}.");

Console.ReadLine();