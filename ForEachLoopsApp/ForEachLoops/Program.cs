

string data = "Tim,Sue,Bob,Jane";
List<string> firstNames = data.Split(',').ToList();

// Loop through every element in a set
foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);
}

// Sometime we see "var firstName in firstNames". "var" means it will 
// be the data type that it was first assigned to. In this case, since
// firstNames is a list of string, so "var" will be string.