using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to lower the target's Defense by one stage.
	public class MoveCrushClaw : Move
	{
		public MoveCrushClaw() : base(
			"Crush-Claw",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 75,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}