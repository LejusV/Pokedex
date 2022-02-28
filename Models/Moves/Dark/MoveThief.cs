using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Takes the target's item.
	public class MoveThief : Move
	{
		public MoveThief() : base(
			"Thief",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}