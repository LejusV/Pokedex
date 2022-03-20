using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveBehemothBlade : Move
	{
#nullable enable
		private static MoveBehemothBlade? _instance = null;
#nullable restore
        public static MoveBehemothBlade Instance => _instance ?? (_instance = new MoveBehemothBlade());

		public MoveBehemothBlade() : base(
			"Behemoth-Blade",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}