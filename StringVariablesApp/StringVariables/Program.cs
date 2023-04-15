

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Tom";
lastName = "Jerry";

Console.WriteLine(firstName + " " + lastName + ".");

// String interpolation
Console.WriteLine($"My name is {firstName} {lastName}.");

//filePath = "C:\\Temp\\Docs\\One";

// Verbatim string literal
filePath = @"C:\Temp\Docs\Two";

Console.WriteLine(filePath);

Console.WriteLine($@"We can find {firstName}'s files at C:\SampleFiles");

Console.ReadLine();