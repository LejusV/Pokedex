using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User swaps Attack and Special Attack changes with the target.
	public class MovePowerSwap : Move
	{
		public MovePowerSwap() : base(
			"Power-Swap",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}