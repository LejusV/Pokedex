using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Damages opponents, but heals allies for 50% of their max HP.
	public class MovePollenPuff : Move
	{
		public MovePollenPuff() : base(
			"Pollen-Puff",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}