using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//For the next few turns, the target can only use damaging moves.
	public class MoveTaunt : Move
	{
		public MoveTaunt() : base(
			"Taunt",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}