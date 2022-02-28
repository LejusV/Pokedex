using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Speed by one stage.
	public class MoveConstrict : Move
	{
		public MoveConstrict() : base(
			"Constrict",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 10,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}