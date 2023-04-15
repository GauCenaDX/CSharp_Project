

using HWExceptionHandling;

try
{
    ExceptionGenerator.BadDivision();
}
catch (Exception ex)
{
    Console.WriteLine();
    Console.WriteLine("I can catch the exception being thrown from BadDivison().");
    Console.WriteLine(ex.Message);
}
