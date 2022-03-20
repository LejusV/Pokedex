using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Takes the target's item.
	public class MoveThief : Move
	{
#nullable enable
		private static MoveThief? _instance = null;
#nullable restore
        public static MoveThief Instance => _instance ?? (_instance = new MoveThief());

		public MoveThief() : base(
			"Thief",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}