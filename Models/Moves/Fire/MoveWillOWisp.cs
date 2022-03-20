using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Burns the target.
	public class MoveWillOWisp : Move
	{
#nullable enable
		private static MoveWillOWisp? _instance = null;
#nullable restore
        public static MoveWillOWisp Instance => _instance ?? (_instance = new MoveWillOWisp());

		public MoveWillOWisp() : base(
			"Will-O-Wisp",
			Fire.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}