
using ProjGuestBook;

bool isDone = false;
List<string> guestNames = new();
List<int> numberOfGuests = new();

while (isDone == false)
{
    ConsoleMessages.GetPartyName(guestNames);
    ConsoleMessages.GetNumberOfPeople(numberOfGuests);

    Console.Write("Are you done? (Y/N) ");
    string? answer = Console.ReadLine();

    if (answer.ToLower() == "y" || answer.ToLower() == "yes")
    {
        isDone = true;
    }
}

ConsoleMessages.PrintGuestList(guestNames, numberOfGuests);
ConsoleMessages.PrintTotalGuest(numberOfGuests);


Console.WriteLine("End of program.");