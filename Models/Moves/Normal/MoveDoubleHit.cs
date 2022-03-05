using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveDoubleHit : Move
	{
		public MoveDoubleHit() : base(
			"Double-Hit",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 35,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}