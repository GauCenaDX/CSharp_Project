

string firstName = "toMMy";
int age = 189;

switch (firstName.ToLower())
{
    case "sue":
    case "tim":
        Console.WriteLine("Hello Tim or Sue.");
        break;
    case "tom" or "tommy":
        Console.WriteLine("Hello Tom");
        break;
    default:
        Console.WriteLine("I don't know you.");
        break;
}

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child.");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should have a job.");
        break;
    case >= 66:
        Console.WriteLine("Hopefully your are retired or retiring soon.");
        break;
    default:
        Console.WriteLine("Age was not in the expected range.");
        break;
}

Console.WriteLine();
Console.WriteLine("End of program.");