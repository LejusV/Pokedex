using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Blocks damaging attacks and lowers attacking Pokémon's Attack by two stages on contact.  Switches Aegislash to Shield Forme.
	public class MoveKingsShield : Move
	{
		public MoveKingsShield() : base(
			"Kings-Shield",
			Steel.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}