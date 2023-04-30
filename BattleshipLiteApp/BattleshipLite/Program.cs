

using System;
using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;

namespace BattleshipLite
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            PlayerInfoModel player1 = CreatePlayer("Player 1");
            PlayerInfoModel player2 = CreatePlayer("Player 2");

            Console.WriteLine();
            Console.WriteLine("End of Program.");
            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("Welcom to Battleship Lite " + "\u00a9" + "2023");
            Console.WriteLine("-- Create by Duc Nguyen - Instructed by Tim Corey");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle}:");
            Console.WriteLine("--------------------------------------------");

            // Ask the user for their name
            output.PlayerName = AskForUserName();

            // Load up the shot grid
            GameLogic.InitializeGrid(output);

            // Ask the user for their 5 ship placements
            PlaceShips(output);

            // Clear the console
            Console.Clear();

            return output;
        }

        private static string AskForUserName()
        {
            Console.Write("Enter player name: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Enter location to place ship number " +
                    $"{model.ShipLocations.Count + 1}: ");
                string location = Console.ReadLine();

                bool isValidLocation = GameLogic.PlaceShip(model, location);

                if (isValidLocation == false)
                {
                    Console.WriteLine("Please enter a valid location.");
                }

            } while (model.ShipLocations.Count < 5);
        }
    }
}



