using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveCrossChop : Move
	{
		public MoveCrossChop() : base(
			"Cross-Chop",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			0.8, 0 // Acc & Priority
		) {}
	}
}