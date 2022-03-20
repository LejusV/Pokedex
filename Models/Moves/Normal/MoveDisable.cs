using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Disables the target's last used move for 1-8 turns.
	public class MoveDisable : Move
	{
#nullable enable
		private static MoveDisable? _instance = null;
#nullable restore
        public static MoveDisable Instance => _instance ?? (_instance = new MoveDisable());

		public MoveDisable() : base(
			"Disable",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}