using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to paralyze the target.
	public class MoveZapCannon : Move
	{
		public MoveZapCannon() : base(
			"Zap-Cannon",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 120,// PP & Pow
			0.5, 0 // Acc & Priority
		) {}
	}
}