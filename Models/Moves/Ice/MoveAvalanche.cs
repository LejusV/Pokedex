using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts double damage if the user takes damage before attacking this turn.
	public class MoveAvalanche : Move
	{
#nullable enable
		private static MoveAvalanche? _instance = null;
#nullable restore
        public static MoveAvalanche Instance => _instance ?? (_instance = new MoveAvalanche());

		public MoveAvalanche() : base(
			"Avalanche",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			100, -4 // Acc & Priority
		) {}
	}
}