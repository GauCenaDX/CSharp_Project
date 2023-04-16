

using System;

namespace HWCalculationWithStaticClasses
{
	public static class UserMessages
	{
		public static void WelcomeMessage()
		{
			int hourOfDay = DateTime.Now.Hour;
			string welcomeMessage = "Welcome to our Calculation App.";

			if (hourOfDay < 12)
			{
				Console.WriteLine("Good Morning!");
			}
			else if (hourOfDay < 19)
			{
				Console.WriteLine("Good Afternoon!");
			}
			else
			{
				Console.WriteLine("Good Evening!");
			}

			Console.WriteLine(welcomeMessage);
		}

		public static void PrintResult(string message)
		{
			Console.WriteLine(message);
		}

		public static void GoodByeUser()
		{
			Console.WriteLine("Thank you for using our Calculating App. Bye Bye ^_^");
		}
	}
}

