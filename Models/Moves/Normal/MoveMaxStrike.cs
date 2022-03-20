using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxStrike : Move
	{
#nullable enable
		private static MoveMaxStrike? _instance = null;
#nullable restore
        public static MoveMaxStrike Instance => _instance ?? (_instance = new MoveMaxStrike());

		public MoveMaxStrike() : base(
			"Max-Strike",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}