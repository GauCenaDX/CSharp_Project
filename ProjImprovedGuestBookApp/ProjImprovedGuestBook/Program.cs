

// Capture the information about each guest (assumtion is at least one
// guest and unknown maximum)
// Info to capture: First name, last name, message to the host
// Once done, loop through each guest and print their info

using GuestBookLibrary.Models;
using System;

namespace ProjImprovedGuestBook;

class Program
{
    // Variables can live outside of the Main method.
    // Tip: consider how long the variable should exist.
    static List<GuestModel> guests = new List<GuestModel>();

    static void Main(string[] args)
    {
        GetGuestInformation();

        PrintGuestInformation();

        Console.WriteLine();
        Console.WriteLine("End of program.");
        Console.ReadLine();
    }

    private static void GetGuestInformation()
    {
        string moreGuestComing = "";

        do
        {
            GuestModel guest = new GuestModel();

            guest.FirstName = GetInfoFromConsole("Enter guest first name: ");
            guest.LastName = GetInfoFromConsole("Enter guest last name: ");
            guest.MessageToHost = GetInfoFromConsole("Guest message to host: ");

            moreGuestComing = GetInfoFromConsole("Is there any more guest " +
                "coming? (yes to continue) "); ;

            guests.Add(guest);
            Console.Clear();
        } while (moreGuestComing.ToLower() == "yes");
    }

    private static void PrintGuestInformation()
    {
        foreach (GuestModel guest in guests)
        {
            Console.WriteLine(guest.GuestInfo);
        }
    }

    private static string GetInfoFromConsole(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();

        return input;
    }
}


