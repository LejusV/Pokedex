using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Ignores the target's stat modifiers.
	public class MoveChipAway : Move
	{
		public MoveChipAway() : base(
			"Chip-Away",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}