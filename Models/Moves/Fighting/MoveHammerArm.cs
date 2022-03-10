using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Lowers user's Speed by one stage.
	public class MoveHammerArm : Move
	{
		public MoveHammerArm() : base(
			"Hammer-Arm",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}