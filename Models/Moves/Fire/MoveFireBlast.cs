using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.
	public class MoveFireBlast : Move
	{
		public MoveFireBlast() : base(
			"Fire-Blast",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 110,// PP & Pow
			0.85, 0 // Acc & Priority
		) {}
	}
}