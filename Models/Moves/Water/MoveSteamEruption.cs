using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to burn the target.
	public class MoveSteamEruption : Move
	{
		public MoveSteamEruption() : base(
			"Steam-Eruption",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 110,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}