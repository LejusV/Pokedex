using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveAirCutter : Move
	{
#nullable enable
		private static MoveAirCutter? _instance = null;
#nullable restore
        public static MoveAirCutter Instance => _instance ?? (_instance = new MoveAirCutter());

		public MoveAirCutter() : base(
			"Air-Cutter",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 60,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}