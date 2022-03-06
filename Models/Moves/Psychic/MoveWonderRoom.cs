using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//All Pokémon's Defense and Special Defense are swapped for 5 turns.
	public class MoveWonderRoom : Move
	{
		public MoveWonderRoom() : base(
			"Wonder-Room",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}