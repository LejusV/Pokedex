using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveDischarge : Move
	{
#nullable enable
		private static MoveDischarge? _instance = null;
#nullable restore
        public static MoveDischarge Instance => _instance ?? (_instance = new MoveDischarge());

		public MoveDischarge() : base(
			"Discharge",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}