using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to make the target flinch.
	public class MoveTwister : Move
	{
		public MoveTwister() : base(
			"Twister",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 40,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}