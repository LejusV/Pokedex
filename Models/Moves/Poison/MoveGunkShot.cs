using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to poison the target.
	public class MoveGunkShot : Move
	{
		public MoveGunkShot() : base(
			"Gunk-Shot",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			0.8, 0 // Acc & Priority
		) {}
	}
}