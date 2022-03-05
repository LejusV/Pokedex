using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Target drops its held item.
	public class MoveKnockOff : Move
	{
		public MoveKnockOff() : base(
			"Knock-Off",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}