

// - Create a Console Application
// - Ask user for first name
// - Welcome Tim/Timothy as professor
// - Welcome anyone else as student

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if ((firstName.ToLower() == "tim") || (firstName.ToLower() == "timothy"))
{
    Console.WriteLine("Hello proffesor Corey.");
}
else
{
    Console.WriteLine("Hello student.");
}

Console.WriteLine();
Console.WriteLine("End of program.");