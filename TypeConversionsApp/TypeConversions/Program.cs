

Console.Write("What is your age: ");
string? ageText = Console.ReadLine();

//Console.WriteLine(ageText + 15); // input: 43, output: 4315

// Using Parse
//int age = int.Parse(ageText);
//Console.WriteLine(age + 15);

//int age;

// This will print out age even if it has invalid value
bool isValidInt = int.TryParse(ageText, out int age);
Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");

// Using Cast
double testDouble = age;
decimal testDecimal = (decimal)testDouble;
Console.WriteLine();
Console.WriteLine(testDouble);
Console.WriteLine(testDecimal);



Console.ReadLine();