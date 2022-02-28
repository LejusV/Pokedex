using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to poison the target.
	public class MoveSludge : Move
	{
		public MoveSludge() : base(
			"Sludge",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}