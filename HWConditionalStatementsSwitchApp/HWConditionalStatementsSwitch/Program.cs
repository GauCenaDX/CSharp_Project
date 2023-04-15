

// - Create a Console Application
// - Ask user for first name
// - Welcome Tim/Timothy as professor
// - Welcome anyone else as student

Console.Write("What is your first name: ");

string? firstName = Console.ReadLine();

switch (firstName.ToLower())
{
    case "tim" or "timothy":
        Console.WriteLine("Hello professor Corey.");
        break;
    default:
        Console.WriteLine("Hello student.");
        break;
}

Console.WriteLine();
Console.WriteLine("End of program.");