using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveSwift : Move
	{
#nullable enable
		private static MoveSwift? _instance = null;
#nullable restore
        public static MoveSwift Instance => _instance ?? (_instance = new MoveSwift());

		public MoveSwift() : base(
			"Swift",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}