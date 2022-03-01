using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Explodes if the target uses a fire move this turn, damaging it for 1/4 its max HP and preventing the move.
	public class MovePowder : Move
	{
		public MovePowder() : base(
			"Powder",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			1.0, 1 // Acc & Priority
		) {}
	}
}