

// - Ask for a list of 3 IDs
// - Ask for a list of 3 names
// - Put them in a Dictionary List
// - Ask user to select an ID
// - Return the name that correspond to the ID

int numberOfRecords = 3;

Console.Write($"Give me {numberOfRecords} IDs separated by comma: ");
string? data = Console.ReadLine();

List<string> IDList = data.Split(',').ToList();

Console.Write($"Give me {numberOfRecords} names separated by comma: ");
data = Console.ReadLine();

List<string> nameList = data.Split(',').ToList();

int index = 0;
Dictionary<string, string> employees = new Dictionary<string, string>();
while (index < numberOfRecords)
{
    employees[IDList[index]] = nameList[index];
    index++;
}

index = 0;
while (index < numberOfRecords)
{
    Console.WriteLine($"{index} - {IDList[index]}");
    index++;
}

string? numberText;
int number;
bool isValidNumber = false;
do
{
    Console.Write("Select one ID listed above: ");
    numberText = Console.ReadLine();

    if (int.TryParse(numberText, out number) == false)
    {
        Console.WriteLine("Please select the correct number.");
    }
    else if (number < 0 || number >= numberOfRecords)
    {
        Console.WriteLine("Your number is out of range.");
    }
    else {
        Console.WriteLine($"The employee's name is {employees[IDList[number]]}.");
        isValidNumber = true;
    }
} while (isValidNumber == false);

Console.WriteLine("End of program.");