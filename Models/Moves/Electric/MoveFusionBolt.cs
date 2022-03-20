using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//With Fusion Flare, inflicts double damage.
	public class MoveFusionBolt : Move
	{
#nullable enable
		private static MoveFusionBolt? _instance = null;
#nullable restore
        public static MoveFusionBolt Instance => _instance ?? (_instance = new MoveFusionBolt());

		public MoveFusionBolt() : base(
			"Fusion-Bolt",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}