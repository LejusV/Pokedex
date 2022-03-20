using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Special Attack by one stage.
	public class MoveStruggleBug : Move
	{
#nullable enable
		private static MoveStruggleBug? _instance = null;
#nullable restore
        public static MoveStruggleBug Instance => _instance ?? (_instance = new MoveStruggleBug());

		public MoveStruggleBug() : base(
			"Struggle-Bug",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}