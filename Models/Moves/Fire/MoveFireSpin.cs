using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveFireSpin : Move
	{
		public MoveFireSpin() : base(
			"Fire-Spin",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 35,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}