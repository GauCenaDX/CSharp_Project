

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

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                Console.WriteLine();
                DisplayShotGrid(activePlayer);
                Console.WriteLine("\n\n");

                RecordPlayerShot(activePlayer, opponent);

                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                if (doesGameContinue == true)
                {
                    (activePlayer, opponent) = (opponent, activePlayer);
                }
                else
                {
                    winner = activePlayer;
                }
            } while (winner == null);

            IdentifyWinner(winner);

            Console.WriteLine();
            Console.WriteLine("End of Program.");
            Console.ReadLine();
        }

        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine();
            Console.WriteLine("**************************************************************");
            Console.WriteLine($"Congratulation to {winner.PlayerName} for winning!");
            Console.WriteLine($"{winner.PlayerName} took {GameLogic.GetShotCount(winner)} shots.");
        }

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
                // Ask for a shot (ask for "B2", not "B" then "2")
                string shot = AskForShot(activePlayer);
                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    isValidShot = false;
                }

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid shot location. Please try again.");
                }
            } while (isValidShot == false);

            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);

            DisplayShotResults(row, column, isAHit);
        }

        private static void DisplayShotResults(string row, int column, bool isAHit)
        {
            if (isAHit)
            {
                Console.WriteLine($"{row}{column} is a Hit!");
            }
            else
            {
                Console.WriteLine($"{row}{column} is a miss.");
            }
        }

        private static string AskForShot(PlayerInfoModel player)
        {
            Console.Write($"{player.PlayerName}, please enter your shot selection: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void DisplayShotGrid(PlayerInfoModel player)
        {
            //   - Empty = -
            //   - Hit = X
            //   - Miss = O
            //   - Other = ?

            Console.Write("   1  2  3  4  5");
            string currentRow = "?";
            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                    Console.Write(currentRow);
                }

                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($"  -");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write("  X");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write("  O");
                }
                else
                {
                    Console.Write("  ?");
                }
                
            }
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

            output.PlayerName = AskForUserName();
            GameLogic.InitializeGrid(output);
            PlaceShips(output);
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

                bool isValidLocation = false;
                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, location);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                if (isValidLocation == false)
                {
                    Console.WriteLine("Please enter a valid location.");
                }

            } while (model.ShipLocations.Count < 5);
        }
    }
}

