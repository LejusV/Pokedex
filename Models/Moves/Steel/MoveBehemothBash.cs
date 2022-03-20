using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveBehemothBash : Move
	{
#nullable enable
		private static MoveBehemothBash? _instance = null;
#nullable restore
        public static MoveBehemothBash Instance => _instance ?? (_instance = new MoveBehemothBash());

		public MoveBehemothBash() : base(
			"Behemoth-Bash",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}