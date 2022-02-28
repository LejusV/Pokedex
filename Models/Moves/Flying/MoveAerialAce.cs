using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveAerialAce : Move
	{
		public MoveAerialAce() : base(
			"Aerial-Ace",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}