using System;
namespace Methods
{
	internal static class ConsoleMessages
	{
		public static void SayHi(string firstName)
		{
			Console.WriteLine($"Hello {firstName}!");
			Console.WriteLine("I hope you have a good day.");
		}

		public static string GetUserName()
		{
			Console.Write("What is your name: ");
			string name = Console.ReadLine();

			return name;
		}

		public static void SayGoodBye()
		{
			Console.WriteLine("Goodbye my user.");
			Console.WriteLine("Thank you for visiting.");
			Console.WriteLine("I cannot wait to see you again.");
		}
	}
}
