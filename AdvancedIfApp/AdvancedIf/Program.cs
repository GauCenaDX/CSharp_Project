

Console.Write("What is your first Name: ");
string firstName = Console.ReadLine();

Console.Write("What is your lastName: ");
string lastName = Console.ReadLine();

// We can save the horizontal space by breaking long statement at the
// logical point
if (firstName.ToLower() == "tim" &&
    lastName.ToLower() == "corey")
{
    Console.WriteLine("Hello professor Corey.");
}
else if (firstName.ToLower() == "tim" ||
    lastName.ToLower() == "corey")
{
    Console.WriteLine("You have a great part in your name.");
}
else
{
    Console.WriteLine("Hello student.");
}


int age = 73;

// Comparison: ==, >, >=, <, <=, !=
if (age != 35)
{
    Console.WriteLine("Sorry you are not 35 year olds.");
}

if ((age >= 40 && age < 50) ||
    (age >= 70 && age < 80))
{
    Console.WriteLine("You are in your 40's or 70's.");
}


Console.WriteLine();
Console.WriteLine("End of program.");