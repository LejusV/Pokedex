using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ignores the target's stat modifiers.
	public class MoveChipAway : Move
	{
#nullable enable
		private static MoveChipAway? _instance = null;
#nullable restore
        public static MoveChipAway Instance => _instance ?? (_instance = new MoveChipAway());

		public MoveChipAway() : base(
			"Chip-Away",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}