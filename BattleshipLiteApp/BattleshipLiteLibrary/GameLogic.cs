
using System;
using BattleshipLiteLibrary.Models;

namespace BattleshipLiteLibrary
{
	public static class GameLogic
	{
		public static void InitializeGrid(PlayerInfoModel model)
		{
			List<string> letters = new List<string>
			{
				"A",
				"B",
				"C",
				"D",
				"E"
			};

			List<int> numbers = new List<int>
			{
				1,
				2,
				3,
				4,
				5
			};

			foreach (string letter in letters)
			{
				foreach (int number in numbers)
				{
					AddGridSpot(model, letter, number);
				}
			}
		}

		private static void AddGridSpot(PlayerInfoModel model, string letter,
			int number)
		{
			GridSpotModel spot = new GridSpotModel
			{
				SpotLetter = letter,
				SpotNumber = number,
				Status = GridSpotStatus.Empty
			};

			model.ShotGrid.Add(spot);
		}

		public static bool PlaceShip(PlayerInfoModel player, string location)
		{
			bool output = false;
			(string row, int column) = SplitShotIntoRowAndColumn(location);

			bool isValidLocation = ValidateGridLocation(player, row, column);
			bool isSpotOpen = ValidateShipLocation(player, row, column);

			if (isValidLocation && isSpotOpen)
			{
				player.ShipLocations.Add(new GridSpotModel
				{
					SpotLetter = row.ToUpper(),
					SpotNumber = column,
					Status = GridSpotStatus.Ship
				});

				output = true;
			}

			return output;
		}

        private static bool ValidateShipLocation(PlayerInfoModel player, string row, int column)
        {
			bool isValidLocation = true;

			foreach (var ship in player.ShipLocations)
			{
				if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
				{
					isValidLocation = false;
				}
			}

			return isValidLocation;
        }

        private static bool ValidateGridLocation(PlayerInfoModel player, string row, int column)
		{
            bool isValidLocation = false;

            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    isValidLocation = true;
                }
            }

            return isValidLocation;
        }

		public static bool PlayerStillActive(PlayerInfoModel player)
		{
			// Check if at least one ship is not sunk
			bool isActive = false;

			foreach (var ship in player.ShipLocations)
			{
				if (ship.Status != GridSpotStatus.Sunk)
				{
					isActive = true;
				}
			}

			return isActive;
		}

        public static int GetShotCount(PlayerInfoModel player)
        {
			int shotCount = 0;

			foreach (var shot in player.ShotGrid)
			{
				if (shot.Status != GridSpotStatus.Empty)
				{
					shotCount += 1;
				}
			}

			return shotCount;
        }

        public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
			string row = "";
			int column = 0;

			if (shot.Length != 2)
			{
				// ArgumentException(string? message, string? paramName)
				throw new ArgumentException("This was an invalid shot type.", "shot");
			}

			char[] shotArray = shot.ToArray();

			row = shotArray[0].ToString();
			// Assuming that user gave us a valid column number
			column = int.Parse(shotArray[1].ToString());

			return (row, column);
        }

        public static bool ValidateShot(PlayerInfoModel player, string row, int column)
        {
			bool isValidShot = false;

			foreach (var spot in player.ShotGrid)
			{
				if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
				{
					if (spot.Status == GridSpotStatus.Empty)
					{
                        isValidShot = true;
                    }
				}
			}

			return isValidShot;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
			bool isAHit = false;

            foreach (var ship in opponent.ShipLocations)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isAHit = true;
					ship.Status = GridSpotStatus.Sunk;
                }
            }

			return isAHit;
        }

        public static void MarkShotResult(PlayerInfoModel player, string row, int column, bool isAHit)
        {
			foreach (var gridSpot in player.ShotGrid)
			{
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
					if (isAHit)
					{
						gridSpot.Status = GridSpotStatus.Hit;
					}
					else
					{
						gridSpot.Status = GridSpotStatus.Miss;
					}
                }
            }
        }
    }
}

