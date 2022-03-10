using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Special Attack, Special Defense, and Speed by one stage each.
	public class MoveQuiverDance : Move
	{
		public MoveQuiverDance() : base(
			"Quiver-Dance",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}