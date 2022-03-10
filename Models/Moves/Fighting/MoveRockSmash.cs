using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to lower the target's Defense by one stage.
	public class MoveRockSmash : Move
	{
		public MoveRockSmash() : base(
			"Rock-Smash",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}