using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's evasion by two stages.
	public class MoveMinimize : Move
	{
#nullable enable
		private static MoveMinimize? _instance = null;
#nullable restore
        public static MoveMinimize Instance => _instance ?? (_instance = new MoveMinimize());

		public MoveMinimize() : base(
			"Minimize",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}