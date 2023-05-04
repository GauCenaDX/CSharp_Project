
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
			// Validate location input
			// If the input is valid, check if there is already ship placed at that spot
			// If no ship at that location, place a ship there
			// Return if ship is placed successfully

			bool isValidLocationInput = false;
			bool isShipPlaced = false;
			bool isSpotTaken = false;
			string startLetter = "A";
			string endLetter = "E";
			int startNumber = 1;
			int endNumber = 5;
            string locationLetter = "";
            int locationNumber = 0;

            if (location.Length >= 2)
			{
                locationLetter = location[0].ToString();
                bool isANumber = int.TryParse(location.Substring(1), out locationNumber);

				if (locationLetter.ToUpper().CompareTo(startLetter) >= 0 &&
					locationLetter.ToUpper().CompareTo(endLetter) <= 0)
				{
					if (isANumber == true && locationNumber >= startNumber &&
					locationNumber <= endNumber)
					{
						isValidLocationInput = true;
					}
                }
            }

			if (isValidLocationInput == true)
			{
				foreach (var spot in player.ShipLocations)
				{
					if (spot.SpotLetter == locationLetter.ToUpper() &&
						spot.SpotNumber == locationNumber)
					{
						isSpotTaken = true;
					}
				}

				if (isSpotTaken == false)
				{
					GridSpotModel spot = new GridSpotModel()
					{
						SpotLetter = locationLetter.ToUpper(),
						SpotNumber = locationNumber,
						Status = GridSpotStatus.Ship
					};

					player.ShipLocations.Add(spot);
					isShipPlaced = true;
				}
			}

			return isShipPlaced;
		}

		public static bool PlayerStillActive(PlayerInfoModel player)
		{
			bool isPlayerActive = false;

			foreach (var spot in player.ShipLocations)
			{
				if (spot.Status == GridSpotStatus.Ship)
				{
					isPlayerActive = true;
				}
			}

			return isPlayerActive;
		}

        public static int GetShotCount(PlayerInfoModel winner)
        {
			int shotCount = 0;

			foreach (var spot in winner.ShotGrid)
			{
				if (spot.Status != GridSpotStatus.Empty)
				{
					++shotCount;
				}
			}

			return shotCount;
        }

        public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
			string shotLetter = "";
			int shotNumber = -1;

			if (shot.Length >= 2)
            {
                shotLetter = shot[0].ToString();
                bool isANumber = int.TryParse(shot.Substring(1), out shotNumber);
            }

			return (shotLetter, shotNumber);
        }

        public static bool ValidateShot(PlayerInfoModel activePlayer, string row, int column)
        {
			bool isValidShot = false;

			foreach (var spot in activePlayer.ShotGrid)
			{
				if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column &&
					spot.Status == GridSpotStatus.Empty)
				{
					isValidShot = true;
				}
			}

			return isValidShot;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent,
			string row, int column)
        {
			bool isAHit = false;

            foreach (var spot in opponent.ShipLocations)
            {
                if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column &&
                    spot.Status == GridSpotStatus.Ship)
                {
                    isAHit = true;
					spot.Status = GridSpotStatus.Sunk;
                }
            }

			return isAHit;
        }

        public static void MarkShotResult(PlayerInfoModel activePlayer,
			string row, int column, bool isAHit)
        {
			foreach (var spot in activePlayer.ShotGrid)
			{
                if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
                {
					if (isAHit == true)
					{
						spot.Status = GridSpotStatus.Hit;
					}
					else
					{
						spot.Status = GridSpotStatus.Miss;
					}
                }
            }
        }
    }
}

