using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User swaps Attack and Defense.
	public class MovePowerTrick : Move
	{
		public MovePowerTrick() : base(
			"Power-Trick",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}