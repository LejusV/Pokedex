using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to confuse the target.
	public class MoveRockClimb : Move
	{
		public MoveRockClimb() : base(
			"Rock-Climb",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 90,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}