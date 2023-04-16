

using System;

namespace HWCalculationWithStaticClasses
{
	public static class RequestData
	{
		public static double GetADouble(string message)
		{
			double output = 0;

            Console.Write(message);
            string numberText = Console.ReadLine();
            bool isDouble = double.TryParse(numberText, out output); ;

            while (isDouble == false)
			{
				Console.WriteLine("Please enter a valid number.");
				Console.Write(message);
                numberText = Console.ReadLine();

                isDouble = double.TryParse(numberText, out output);
            }

			return output;
		}
	}
}

