using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Adds ghost to the target's types.
	public class MoveTrickOrTreat : Move
	{
		public MoveTrickOrTreat() : base(
			"Trick-Or-Treat",
			Ghost.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}