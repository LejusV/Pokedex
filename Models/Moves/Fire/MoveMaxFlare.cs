using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxFlare : Move
	{
#nullable enable
		private static MoveMaxFlare? _instance = null;
#nullable restore
        public static MoveMaxFlare Instance => _instance ?? (_instance = new MoveMaxFlare());

		public MoveMaxFlare() : base(
			"Max-Flare",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}