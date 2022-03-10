using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveArmThrust : Move
	{
		public MoveArmThrust() : base(
			"Arm-Thrust",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 15,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}