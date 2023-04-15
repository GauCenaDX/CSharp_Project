

// 0-based counting - 0,1,2,3,4
// 1-based counting - 1,2,3,4,5

//string[] firstNames = new string[5];

//firstNames[0] = "Tim";
//firstNames[1] = "Sue";
//firstNames[2] = "Bob";
//firstNames[4] = "Jane";

//Console.WriteLine($"The first names are {firstNames[0]}, {firstNames[1]}, " +
//    $"{firstNames[2]}, {firstNames[4]}");

//firstNames[0] = "Timothy";
//Console.WriteLine(firstNames[0]);

//firstNames[5] = "Robert";  // IndexOutOfRangeException


// Single quotes identify a char
// Double quotes identify a string
string data = "Tim,Sue,Bob,Jane,Frank";
string[] firstNames = data.Split(',');

Console.WriteLine(firstNames.Length);
Console.WriteLine(firstNames[firstNames.Length - 1]);

Console.WriteLine();
string[] LastNames = new string[] { "Corey", "Smith", "Jones" };
int[] ages = new int[] { 2, 3, 4 };

Console.WriteLine(LastNames[1]);
Console.WriteLine(ages[0]);