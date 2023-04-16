

using HWCalculationWithStaticClasses;

UserMessages.WelcomeMessage();

Console.WriteLine();
double x = RequestData.GetADouble("Please enter the first number: ");
double y = RequestData.GetADouble("Please enter the second number: ");

double result = 0;

result = CalculateData.Add(x, y);
UserMessages.PrintResult($"The result for {x} + {y} is {result}.");

result = CalculateData.Subtract(x, y);
UserMessages.PrintResult($"The result for {x} - {y} is {result}.");

result = CalculateData.Multiply(x, y);
UserMessages.PrintResult($"The result for {x} * {y} is {result}.");

try
{
    result = CalculateData.Divide(x, y);
    UserMessages.PrintResult($"The result for {x} / {y} is {result}.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception)
{
    Console.WriteLine("There was an error with the Division Calculation.");
}


Console.WriteLine();
Console.WriteLine("End Of Program.");