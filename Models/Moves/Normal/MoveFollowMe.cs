using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Redirects the target's single-target effects to the user for this turn.
	public class MoveFollowMe : Move
	{
		public MoveFollowMe() : base(
			"Follow-Me",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 2 // Acc & Priority
		) {}
	}
}