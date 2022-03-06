using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power increases as happiness decreases, up to a maximum of 102.
	public class MoveFrustration : Move
	{
		public MoveFrustration() : base(
			"Frustration",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}