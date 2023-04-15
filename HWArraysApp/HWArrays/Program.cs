

// - Create an array of 3 names
// - Ask user to select a number
// - Print out the name at the index given by user
// - Check for invalid numbers (treat user input as text/string data type)
// - Check for out of bound numbers

string[] names = new string[] { "Duc", "No", "Levi" };
Console.Write("Select a number from 0, 1,or 2: ");
string? numberText = Console.ReadLine();

if (int.TryParse(numberText, out int number) == false)
{
    Console.WriteLine($"{numberText} is not a valid number.");
}
else if (number < 0 || number > 2)
{
    Console.WriteLine($"You number is out of range. " +
        $"Choose either 0, 1, or 2 only.");
}
else
{
    Console.WriteLine($"The name is {names[number]}");
}

Console.WriteLine("End of program.");