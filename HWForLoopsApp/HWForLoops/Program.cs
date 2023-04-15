

// - Ask user for comma-separated list of first names (no spaces)
// - Split the string into a string array
// - Loop through the array and print "Hello <name>" for each person

Console.Write("Enter a comma-separated list of first names (no spaces): ");
string? data = Console.ReadLine();

string[] names = data.Split(',').ToArray();

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Hello {names[i]}.");
}

Console.WriteLine("End of program.");