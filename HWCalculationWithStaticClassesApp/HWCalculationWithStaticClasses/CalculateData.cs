

using System;

namespace HWCalculationWithStaticClasses
{
    public static class CalculateData
    {
        public static double Add(double x, double y)
        {
            double result = x + y;

            return result;
        }

        public static double Subtract(double x, double y)
        {
            double result = x - y;

            return result;
        }

        public static double Multiply(double x, double y)
        {
            double result = x * y;

            return result;
        }

        public static double Divide(double x, double y)
        {
            double result = 0;

            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0.");
            }
            else
            {
                result = x / y;
            }

            return result;
        }
    }
}