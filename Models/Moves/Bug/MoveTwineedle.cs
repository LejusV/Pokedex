using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in the same turn.  Has a 20% chance to poison the target.
	public class MoveTwineedle : Move
	{
#nullable enable
		private static MoveTwineedle? _instance = null;
#nullable restore
        public static MoveTwineedle Instance => _instance ?? (_instance = new MoveTwineedle());

		public MoveTwineedle() : base(
			"Twineedle",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 25,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}