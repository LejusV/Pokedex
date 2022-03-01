using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveNeedleArm : Move
	{
		public MoveNeedleArm() : base(
			"Needle-Arm",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 60,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}