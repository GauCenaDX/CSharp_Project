
// HW: Build a Class Library (.NET Standard) with a class that does the basic
// math operations. Create unit tests for all methods.
using System;

namespace MathOperationLibrary
{
	public static class MathOperations
	{
		public static double Add(double x, double y)
		{
			return x + y;
		}

		public static double Subtract(double x, double y)
		{
			return x - y;
		}

		public static double Multiply(double x, double y)
		{
			return x * y;
		}

		public static double Divide(double x, double y)
		{
			double result = 0;

			if (y == 0)
			{
				result = 0;
			}
			else
			{
				result = x / y;
			}

			return result;
		}
	}
}
