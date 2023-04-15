

using System;

namespace HWExceptionHandling
{
    public static class ExceptionGenerator
    {
        public static void BadDivision()
        {
            for (int i = 0; i < 5; i++)
            {
                int numerator = 20;
                int denominator = 4 - i;

                try
                {
                    Console.Write($"{numerator} / {denominator} is ");

                    int result = numerator / denominator;

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("An exception being caught in BadDivision().");
                    Console.WriteLine(ex);

                    Console.WriteLine("Throw this exception up to whoever calls it.");
                    //throw;
                    throw new Exception("Error from BadDivision(): You can't " +
                        "divide a number by zero. Please go study basic math again.", ex);
                }
            }

            Console.WriteLine();
            Console.WriteLine("This is the end of the calculation.");
        }
    }
}