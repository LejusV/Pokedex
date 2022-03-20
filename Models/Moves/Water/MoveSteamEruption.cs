using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to burn the target.
	public class MoveSteamEruption : Move
	{
#nullable enable
		private static MoveSteamEruption? _instance = null;
#nullable restore
        public static MoveSteamEruption Instance => _instance ?? (_instance = new MoveSteamEruption());

		public MoveSteamEruption() : base(
			"Steam-Eruption",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 110,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}