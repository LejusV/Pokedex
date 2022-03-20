using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Always scores a critical hit.
	public class MoveStormThrow : Move
	{
#nullable enable
		private static MoveStormThrow? _instance = null;
#nullable restore
        public static MoveStormThrow Instance => _instance ?? (_instance = new MoveStormThrow());

		public MoveStormThrow() : base(
			"Storm-Throw",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}