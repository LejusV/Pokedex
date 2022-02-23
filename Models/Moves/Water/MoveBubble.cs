using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Speed by one stage.
	public class MoveBubble : Move
	{
		public MoveBubble() : base(
			"Bubble",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			30, 40,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}