using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User and target swap items.
	public class MoveSwitcheroo : Move
	{
		public MoveSwitcheroo() : base(
			"Switcheroo",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}