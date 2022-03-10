using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Scatters poisoned spikes, poisoning opposing Pokémon that switch in.
	public class MoveToxicSpikes : Move
	{
		public MoveToxicSpikes() : base(
			"Toxic-Spikes",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}