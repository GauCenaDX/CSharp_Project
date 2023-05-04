﻿

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
                // Display grid from Active Player on where they fired
                Console.WriteLine();
                DisplayShotGrid(activePlayer);
                Console.WriteLine("\n\n");

                // Ask Active Player for a shot
                // Determine if it is a valid shot
                // Determine shot results
                RecordPlayerShot(activePlayer, opponent);

                // Determine if the game should continue
                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                // If over, set Active Player as the winner
                // else, swap positions (Active Player to Opponent)
                if (doesGameContinue == true)
                {
                    // Swapping using a temp variable
                    //PlayerInfoModel tempHolder = activePlayer;
                    //activePlayer = opponent;
                    //opponent = tempHolder;

                    // Use Tuple (available since C# 7.0)
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
            // Ask for a shot (ask for "B2", not "B" then "2")
            // Determine what row and column that is - split it apart
            // Determine if that is a valid shot
            // Go back to the beginning if not a valid shot

            bool isValidShot = false;
            string row = "";
            int column = 0;

            Console.WriteLine($"Player {activePlayer.PlayerName} turn -------------------");

            do
            {
                string shot = AskForShot();
                (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                isValidShot = GameLogic.ValidateShot(activePlayer, row, column);

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid shot location. Please try again.");
                }
            } while (isValidShot == false);

            // Determine shot results
            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            // Record results
            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);
        }

        private static string AskForShot()
        {
            Console.Write("Please enter your shot selection: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void DisplayShotGrid(PlayerInfoModel player)
        {
            // Print out the shot grid:
            //   - Empty = {SpotLetter}{SpotNumber}
            //   - Hit = X
            //   - Miss = O
            //   - Other = ?

            string currentRow = player.ShotGrid[0].SpotLetter;
            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                }

                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write("  X ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write("  O");
                }
                else
                {
                    Console.Write("  ? ");
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



