using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit and a 10% chance to poison the target.
	public class MoveCrossPoison : Move
	{
		public MoveCrossPoison() : base(
			"Cross-Poison",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}