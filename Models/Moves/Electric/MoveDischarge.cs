using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveDischarge : Move
	{
		public MoveDischarge() : base(
			"Discharge",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}