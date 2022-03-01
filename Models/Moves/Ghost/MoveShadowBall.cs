using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to lower the target's Special Defense by one stage.
	public class MoveShadowBall : Move
	{
		public MoveShadowBall() : base(
			"Shadow-Ball",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}