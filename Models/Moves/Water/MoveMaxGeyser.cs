using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxGeyser : Move
	{
#nullable enable
		private static MoveMaxGeyser? _instance = null;
#nullable restore
        public static MoveMaxGeyser Instance => _instance ?? (_instance = new MoveMaxGeyser());

		public MoveMaxGeyser() : base(
			"Max-Geyser",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}