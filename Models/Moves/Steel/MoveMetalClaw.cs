using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to raise the user's Attack by one stage.
	public class MoveMetalClaw : Move
	{
		public MoveMetalClaw() : base(
			"Metal-Claw",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 50,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}