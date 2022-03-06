using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveDisarmingVoice : Move
	{
		public MoveDisarmingVoice() : base(
			"Disarming-Voice",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 40,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}