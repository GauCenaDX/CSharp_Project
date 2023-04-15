using System;

namespace ProjGuestBook
{
    public static class ConsoleMessages
    {
        
        public static void GetPartyName(List<string> guestNames)
        {
            bool isValidName = false;

            do
            {
                Console.Write("Please give a name for your party: ");
                string? partyName = Console.ReadLine();

                if (partyName.ToLower() == "")
                {
                    Console.WriteLine("Please enter a valid name.");
                }
                else
                {
                    guestNames.Add(partyName);
                    isValidName = true;
                }
                
            } while (isValidName == false);
        }

        public static void GetNumberOfPeople(List<int> numberOfGuests)
        {
            bool isValidNumber = false;
            do
            {
                Console.Write("How many people in your party: ");
                string? numberText = Console.ReadLine();

                int number = 0;
                if (int.TryParse(numberText, out number) == false)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                else if (number == 0)
                {
                    Console.WriteLine("Must have at least 1 person in the party.");
                }
                else
                {
                    numberOfGuests.Add(number);
                    isValidNumber = true;
                }
            } while (isValidNumber == false);
        }

        public static void PrintGuestList(List<string> guestNames, List<int> numberOfGuests)
        {
            if (guestNames.Count <= 0 || numberOfGuests.Count <= 0)
            {
                Console.WriteLine("Invalid list(s).");
            }
            else
            {
                Console.WriteLine("Here is the guest list:");

                for (int i = 0; i < guestNames.Count; i++)
                {
                    Console.WriteLine($"{guestNames[i]} - {numberOfGuests[i]}");
                }
            }
        }

        public static int CalculateTotalGuest(List<int> numberOfGuests)
        {
            int total = 0;
            if (numberOfGuests.Count > 0)
            {
                foreach (int number in numberOfGuests)
                {
                    total += number;
                }
            }

            return total;
        }

        public static void PrintTotalGuest(List<int> numberOfGuests)
        {
            int total = 0;

            if (numberOfGuests.Count > 0)
            {
                total = CalculateTotalGuest(numberOfGuests);
            }

            Console.WriteLine($"The total number of guests is {total}.");
        }
    }
}