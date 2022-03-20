using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTwinkleTackleSpecial : Move
	{
#nullable enable
		private static MoveTwinkleTackleSpecial? _instance = null;
#nullable restore
        public static MoveTwinkleTackleSpecial Instance => _instance ?? (_instance = new MoveTwinkleTackleSpecial());

		public MoveTwinkleTackleSpecial() : base(
			"Twinkle-Tackle--Special",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}