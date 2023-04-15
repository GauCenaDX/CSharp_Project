

// - Create a class roster List
// - Keep adding students to the list until user want to stop
// - At the end, print out the number of students in the list


List<string> classRosterList = new List<string>();
string? answer;

do
{
    Console.Write("Enter the name of a student to add to the Roster List: ");
    string? name = Console.ReadLine();

    if (name == "")
    {
        Console.WriteLine("You didn't provide any name.");
    }
    else
    {
        classRosterList.Add(name);
    }
    
    Console.Write("Do you want to stop now? (Y) ");
    answer = Console.ReadLine();
} while (answer.ToLower() != "y");

Console.WriteLine($"The number of student is {classRosterList.Count}.");

Console.WriteLine("End of program.");