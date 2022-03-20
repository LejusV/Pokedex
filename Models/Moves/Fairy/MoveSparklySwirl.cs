using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSparklySwirl : Move
	{
#nullable enable
		private static MoveSparklySwirl? _instance = null;
#nullable restore
        public static MoveSparklySwirl Instance => _instance ?? (_instance = new MoveSparklySwirl());

		public MoveSparklySwirl() : base(
			"Sparkly-Swirl",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 120,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}