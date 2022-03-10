using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises the target's Special Attack by one stage and confuses the target.
	public class MoveFlatter : Move
	{
		public MoveFlatter() : base(
			"Flatter",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}