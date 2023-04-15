

bool isComplete = true;

if (isComplete)
{
    Console.WriteLine("The statemenet was true.");
}
else
{
    Console.WriteLine("The statement was false.");
}


// This is also work, but give incorrect and non-intended results.
// So remember to alwasys use curly braces.
//if (isComplete)
//    Console.WriteLine("The statement was true.");
//else
//    Console.WriteLine("The statement was false.");
//    Console.WriteLine("You supposed to see this message only when the statement was false.");


// Understanding scoping:
// Information can be sent to an inner scope, but we cannot access a variable
// declared inside an inner scope.
Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

string? lastName;

if (firstName.ToLower() == "tim")
{
    Console.WriteLine("Hello Mr. Corey.");
    lastName = "Corey";
}
else
{
    Console.WriteLine($"Hello {firstName}.");
    lastName = "Unknown";
}

// Test the unhappy path as well. Example: tIM.
// Think beyond just the normal inputs.
// What can the users do to mess this up?
Console.WriteLine($"Last name: {lastName}.");

Console.WriteLine("End of program.");