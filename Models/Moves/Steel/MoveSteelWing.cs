using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to raise the user's Defense by one stage.
	public class MoveSteelWing : Move
	{
		public MoveSteelWing() : base(
			"Steel-Wing",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 70,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}