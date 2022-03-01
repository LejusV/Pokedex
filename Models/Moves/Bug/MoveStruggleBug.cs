using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Special Attack by one stage.
	public class MoveStruggleBug : Move
	{
		public MoveStruggleBug() : base(
			"Struggle-Bug",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 50,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}