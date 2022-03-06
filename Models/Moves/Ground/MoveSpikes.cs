using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Scatters Spikes, hurting opposing Pokémon that switch in.
	public class MoveSpikes : Move
	{
		public MoveSpikes() : base(
			"Spikes",
			Ground.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}