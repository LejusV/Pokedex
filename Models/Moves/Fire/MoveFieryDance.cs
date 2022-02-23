using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to raise the user's Special Attack by one stage.
	public class MoveFieryDance : Move
	{
		public MoveFieryDance() : base(
			"Fiery-Dance",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}