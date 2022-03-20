using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//With Fusion Bolt, inflicts double damage.
	public class MoveFusionFlare : Move
	{
#nullable enable
		private static MoveFusionFlare? _instance = null;
#nullable restore
        public static MoveFusionFlare Instance => _instance ?? (_instance = new MoveFusionFlare());

		public MoveFusionFlare() : base(
			"Fusion-Flare",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}