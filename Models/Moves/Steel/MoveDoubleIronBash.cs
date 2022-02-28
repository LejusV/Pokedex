using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveDoubleIronBash : Move
	{
		public MoveDoubleIronBash() : base(
			"Double-Iron-Bash",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}