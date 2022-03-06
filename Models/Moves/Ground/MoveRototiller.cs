using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the Attack and Special Attack of all grass Pokémon in battle.
	public class MoveRototiller : Move
	{
		public MoveRototiller() : base(
			"Rototiller",
			Ground.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}