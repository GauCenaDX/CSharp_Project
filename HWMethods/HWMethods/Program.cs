

// - Create a welcome method
// - Create a method to ask for user's name
// - Create a method to tell "Hell <name>"
// - Call all three methods from program.cs

using Methods;

ConsoleMessages.Welcome();

string userName = ConsoleMessages.GetUserName();

//Console.WriteLine($"You entered the name {userName}.");
ConsoleMessages.Greeting(userName);

Console.WriteLine("End of program.");