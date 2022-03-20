using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Randomly inflicts damage with power from 40 to 120 or heals the target for 1/4 its max HP.
	public class MovePresent : Move
	{
#nullable enable
		private static MovePresent? _instance = null;
#nullable restore
        public static MovePresent Instance => _instance ?? (_instance = new MovePresent());

		public MovePresent() : base(
			"Present",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, null,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}