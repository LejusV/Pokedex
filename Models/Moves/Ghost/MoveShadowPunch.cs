using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveShadowPunch : Move
	{
#nullable enable
		private static MoveShadowPunch? _instance = null;
#nullable restore
        public static MoveShadowPunch Instance => _instance ?? (_instance = new MoveShadowPunch());

		public MoveShadowPunch() : base(
			"Shadow-Punch",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}