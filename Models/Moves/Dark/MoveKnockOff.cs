using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Target drops its held item.
	public class MoveKnockOff : Move
	{
#nullable enable
		private static MoveKnockOff? _instance = null;
#nullable restore
        public static MoveKnockOff Instance => _instance ?? (_instance = new MoveKnockOff());

		public MoveKnockOff() : base(
			"Knock-Off",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}