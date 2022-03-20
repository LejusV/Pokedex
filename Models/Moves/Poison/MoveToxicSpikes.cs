using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Scatters poisoned spikes, poisoning opposing Pokémon that switch in.
	public class MoveToxicSpikes : Move
	{
#nullable enable
		private static MoveToxicSpikes? _instance = null;
#nullable restore
        public static MoveToxicSpikes Instance => _instance ?? (_instance = new MoveToxicSpikes());

		public MoveToxicSpikes() : base(
			"Toxic-Spikes",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}