using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power is doubled if the target has already received damage this turn.
	public class MoveAssurance : Move
	{
		public MoveAssurance() : base(
			"Assurance",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}