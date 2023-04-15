

// Dictionary<TKey, TValue>

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human.";
lookup["fish"] = "Not a human that swims";
lookup["human"] = "Us";

Console.WriteLine($"The definition of fish is {lookup["fish"]}.");


Dictionary<int, string> employees = new Dictionary<int, string>();

employees[1] = "Tim Corey";
employees[21] = "Mina Hoshikawa";

Console.WriteLine($"The employee number 21 is {employees[21]}.");


Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thurday"] = 5;
dayOfWeek["Friday"] = 6;

Console.WriteLine($"Wednesday is day number {dayOfWeek["Wednesday"]} " +
    $"in a week.");