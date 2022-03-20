using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveSpikeCannon : Move
	{
#nullable enable
		private static MoveSpikeCannon? _instance = null;
#nullable restore
        public static MoveSpikeCannon Instance => _instance ?? (_instance = new MoveSpikeCannon());

		public MoveSpikeCannon() : base(
			"Spike-Cannon",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 20,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}