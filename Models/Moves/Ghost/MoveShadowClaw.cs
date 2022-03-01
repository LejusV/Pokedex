using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveShadowClaw : Move
	{
		public MoveShadowClaw() : base(
			"Shadow-Claw",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 70,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}