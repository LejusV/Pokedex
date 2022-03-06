using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//For three turns, friendly Pokémon have doubled Speed.
	public class MoveTailwind : Move
	{
		public MoveTailwind() : base(
			"Tailwind",
			Flying.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}