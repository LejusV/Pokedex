using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Makes the target act last this turn.
	public class MoveQuash : Move
	{
#nullable enable
		private static MoveQuash? _instance = null;
#nullable restore
        public static MoveQuash Instance => _instance ?? (_instance = new MoveQuash());

		public MoveQuash() : base(
			"Quash",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}