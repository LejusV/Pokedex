using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cannot be disrupted by abilities.
	public class MoveSunsteelStrike : Move
	{
#nullable enable
		private static MoveSunsteelStrike? _instance = null;
#nullable restore
        public static MoveSunsteelStrike Instance => _instance ?? (_instance = new MoveSunsteelStrike());

		public MoveSunsteelStrike() : base(
			"Sunsteel-Strike",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}