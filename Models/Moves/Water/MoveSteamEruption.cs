using Pokedex.Enums;
using Pokedex.Models.Types;

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
			0.95, 0 // Acc & Priority
		) {}
	}
}