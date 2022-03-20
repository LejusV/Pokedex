using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveSmartStrike : Move
	{
#nullable enable
		private static MoveSmartStrike? _instance = null;
#nullable restore
        public static MoveSmartStrike Instance => _instance ?? (_instance = new MoveSmartStrike());

		public MoveSmartStrike() : base(
			"Smart-Strike",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 70,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}