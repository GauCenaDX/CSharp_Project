

using System.Globalization;

// Using local time and format
//DateTime today = DateTime.Now;
//
//Console.WriteLine(today);
// Behind the scene
//Console.WriteLine(today.ToString());

// When working with date and time, you have to know
// the locale you're working with ==> how the format works

// Using the Coordinated Universal Time
DateTime today = DateTime.UtcNow;

//DateTime birthday = DateTime.Parse("06/17/1992");

// Ignore the culture aspect of where we are at
DateTime birthday = DateTime.ParseExact("06/11/1898", "d/M/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(birthday.ToString());

Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));

Console.ReadLine();