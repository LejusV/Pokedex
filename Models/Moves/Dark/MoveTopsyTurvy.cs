using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inverts the target's stat modifiers.
	public class MoveTopsyTurvy : Move
	{
		public MoveTopsyTurvy() : base(
			"Topsy-Turvy",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}