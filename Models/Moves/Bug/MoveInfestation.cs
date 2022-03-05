using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveInfestation : Move
	{
		public MoveInfestation() : base(
			"Infestation",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 20,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}