

using System;
namespace BattleshipLiteLibrary.Models
{
	public class GridSpotModel
	{
		public string SpotLetter { get; set; }
		public int SpotNumber { get; set; }
        //-- Assign original value to Auto Property
        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty;
	}
}

