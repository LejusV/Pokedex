using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSplishySplash : Move
	{
#nullable enable
		private static MoveSplishySplash? _instance = null;
#nullable restore
        public static MoveSplishySplash Instance => _instance ?? (_instance = new MoveSplishySplash());

		public MoveSplishySplash() : base(
			"Splishy-Splash",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}