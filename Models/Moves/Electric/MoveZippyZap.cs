using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveZippyZap : Move
	{
#nullable enable
		private static MoveZippyZap? _instance = null;
#nullable restore
        public static MoveZippyZap Instance => _instance ?? (_instance = new MoveZippyZap());

		public MoveZippyZap() : base(
			"Zippy-Zap",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 2 // Acc & Priority
		) {}
	}
}