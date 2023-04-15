

//string[] firstNames = new string[5];
List<string> firstNames = new List<string>();

firstNames.Add("Tim");
firstNames.Add("Sue");
firstNames.Add("Bob");
firstNames.Add("Jane");
firstNames.Add("Frank");

Console.WriteLine(firstNames[firstNames.Count - 1]);

// List<T> - generic - choose any data type you want

List<int> ages = new List<int>();

ages.Add(1);
ages.Add(2);
ages.Add(3);

string data = "Corey,Smith,Jones";
List<string> lastNames = data.Split(',').ToList();

lastNames.Add("Franklin");

Console.WriteLine(lastNames[lastNames.Count - 2]);