
using System;

namespace DemoLibrary
{
	public class DisplayMessages
	{
		public string Greeting(string firstName, int hourOfTheDay)
		{
			string output = "";

			// A pseudo example on working with database:
			// We will need Mocking and Dependency Injection
			//DataAccess da = new DataAccess();
			//da.WriteToDB("My Data");

			if (hourOfTheDay < 12)
			{
				output = $"Good morning {firstName}";
			}
			else if (hourOfTheDay < 18)
			{
				output = $"Good afternoon {firstName}";
			}
			else
			{
				output = $"Good evening {firstName}";
			}

			return output;
		}
	}
}

