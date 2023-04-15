

using ConsoleUI;

string name = "";

try
{
    //AdvancedExceptionsGenerator.SimpleMethod();

    //AdvancedExceptionsGenerator.NotImplementedMethod();

    Console.Write("Give me a name:");
    name = Console.ReadLine();

    AdvancedExceptionsGenerator.ComplexMethod(name);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("Catching InvalidOperationException.");
    Console.WriteLine(ex.Message);
}
catch (NotImplementedException ex)
{
    Console.WriteLine("Catching NotImplementedException.");
    Console.WriteLine(ex.Message);
}
//-- Filter out Exceptions based upon given value
catch (Exception) when (name.ToLower() == "tim")
{
    Console.WriteLine("You used the name Tim, didn't you?");
}
catch (Exception ex)
{
    Console.WriteLine("Catching all other Exceptions.");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("I'm always running. I'm useful for cleaning up works.");
}
