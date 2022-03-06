using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has double power if a friendly Pokémon fainted last turn.
	public class MoveRetaliate : Move
	{
		public MoveRetaliate() : base(
			"Retaliate",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}