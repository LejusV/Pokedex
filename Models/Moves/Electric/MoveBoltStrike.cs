using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to paralyze the target.
	public class MoveBoltStrike : Move
	{
		public MoveBoltStrike() : base(
			"Bolt-Strike",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 130,// PP & Pow
			0.85, 0 // Acc & Priority
		) {}
	}
}