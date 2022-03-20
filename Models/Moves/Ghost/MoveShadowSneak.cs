using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveShadowSneak : Move
	{
#nullable enable
		private static MoveShadowSneak? _instance = null;
#nullable restore
        public static MoveShadowSneak Instance => _instance ?? (_instance = new MoveShadowSneak());

		public MoveShadowSneak() : base(
			"Shadow-Sneak",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 40,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}