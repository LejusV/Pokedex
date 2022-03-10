using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Throws held item at the target; power depends on the item.
	public class MoveFling : Move
	{
		public MoveFling() : base(
			"Fling",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}