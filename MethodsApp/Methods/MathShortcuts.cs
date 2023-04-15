using System;

namespace Methods
{
    public static class MathShortcuts
    {
        public static double Add(double x, double y)
        {
            //Console.WriteLine($"The value of {x} + {y} is {x + y}");

            double output = x + y;

            return output;
        }

        public static void AddAll(double[] values)
        {
            double result = 0;

            //values.Sum();

            foreach (double value in values)
            {
                result += value;
            }

            Console.WriteLine($"The total is {result}.");
        }
    }
}