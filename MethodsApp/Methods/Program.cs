

using Methods;

//for (int i = 0; i < 10; i++)
//{
//    ConsoleMessages.SayHi();
//}

// DRY - Don't Repeat Yourself

// S - SRP - Single Responsibility Principle
// O
// L
// I
// D

string? name = ConsoleMessages.GetUserName();

ConsoleMessages.SayHi(name);

double result = MathShortcuts.Add(5,3);
Console.WriteLine($"The result is {result}.");

double[] vals = new double[] { 10, 20, 30, 50 };
MathShortcuts.AddAll(vals);

ConsoleMessages.SayGoodBye();