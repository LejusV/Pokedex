using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts double damage if the user takes damage before attacking this turn.
	public class MoveRevenge : Move
	{
#nullable enable
		private static MoveRevenge? _instance = null;
#nullable restore
        public static MoveRevenge Instance => _instance ?? (_instance = new MoveRevenge());

		public MoveRevenge() : base(
			"Revenge",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			100, -4 // Acc & Priority
		) {}
	}
}