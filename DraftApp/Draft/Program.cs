

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

Console.Write("What is your last name: ");
string? lastName = Console.ReadLine();

// We can save the horizontal space by breaking long statement at the
// logical point.
if (firstName.ToLower() == "tim" &&
    lastName.ToLower() == "corey")
{
    Console.WriteLine("Hello Mr. Corey.");
}
else if (firstName.ToLower() == "tim")
{
                Console.WriteLine("You have a cool first name.");
}
        else if (lastName.ToLower() == "corey")
{
    Console.WriteLine("You have a great last name.");
}
else
{
    Console.WriteLine("Sorry you don't have a cooler name.");
}