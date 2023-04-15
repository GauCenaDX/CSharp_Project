

DateTime today = DateTime.Now;

// Date only, no time related
DateOnly birthday = DateOnly.Parse("06/27/1979");

Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));

Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");

Console.ReadLine();