

// - A Console Application
// - Ask user for their name
// - Welcome Tim as professor
// - Welcome anyone else as student
// - Do this until the user types "exit"

string? userAnswer;
do
{
    Console.Write("What is your first name: ");
    string? firstName = Console.ReadLine();

    if (firstName.ToLower() == "tim")
    {
        Console.WriteLine("Welcome Professor Corey!");
    }
    else
    {
        Console.WriteLine("Welcome student!");
    }

    Console.Write("Type \"exit\" if you want to exit: ");
    userAnswer = Console.ReadLine();
} while (userAnswer.ToLower() != "exit");

Console.WriteLine("End of program.");