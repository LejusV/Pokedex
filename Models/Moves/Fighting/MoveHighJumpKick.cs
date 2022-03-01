using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//If the user misses, it takes half the damage it would have inflicted in recoil.
	public class MoveHighJumpKick : Move
	{
		public MoveHighJumpKick() : base(
			"High-Jump-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 130,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}