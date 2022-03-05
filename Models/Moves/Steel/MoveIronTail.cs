using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to lower the target's Defense by one stage.
	public class MoveIronTail : Move
	{
		public MoveIronTail() : base(
			"Iron-Tail",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 100,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}