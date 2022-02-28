using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Steals the target's move, if it's self-targeted.
	public class MoveSnatch : Move
	{
		public MoveSnatch() : base(
			"Snatch",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}