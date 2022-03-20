using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveDisarmingVoice : Move
	{
#nullable enable
		private static MoveDisarmingVoice? _instance = null;
#nullable restore
        public static MoveDisarmingVoice Instance => _instance ?? (_instance = new MoveDisarmingVoice());

		public MoveDisarmingVoice() : base(
			"Disarming-Voice",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 40,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}