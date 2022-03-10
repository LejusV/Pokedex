using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Forces the target's opponents to aim at the target for the rest of the turn.
	public class MoveSpotlight : Move
	{
		public MoveSpotlight() : base(
			"Spotlight",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 3 // Acc & Priority
		) {}
	}
}