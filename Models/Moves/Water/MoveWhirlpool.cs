using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents the target from leaving battle and inflicts 1/16 its max HP in damage for 2-5 turns.
	public class MoveWhirlpool : Move
	{
		public MoveWhirlpool() : base(
			"Whirlpool",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 35,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}