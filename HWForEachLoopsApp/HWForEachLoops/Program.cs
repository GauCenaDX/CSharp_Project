

// - Continue asking user for first names
// - Loop through each name using foreach
// - Say hello to each person

bool toContinue = true;
List<string> firstNames = new();

while (toContinue == true)
{
    Console.Write("Enter a first name or just hit 'enter' to stop: ");
    string? name = Console.ReadLine();

    if (name != "")
    {
        firstNames.Add(name);
    }
    else
    {
        toContinue = false;
    }
}

foreach (string firstName in firstNames)
{
    Console.WriteLine($"Hello {firstName}.");
}

Console.WriteLine("End of program.");