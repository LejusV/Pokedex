using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveAirSlash : Move
	{
#nullable enable
		private static MoveAirSlash? _instance = null;
#nullable restore
        public static MoveAirSlash Instance => _instance ?? (_instance = new MoveAirSlash());

		public MoveAirSlash() : base(
			"Air-Slash",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 75,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}