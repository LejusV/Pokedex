using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ignores the target's stat modifiers.
	public class MoveDarkestLariat : Move
	{
#nullable enable
		private static MoveDarkestLariat? _instance = null;
#nullable restore
        public static MoveDarkestLariat Instance => _instance ?? (_instance = new MoveDarkestLariat());

		public MoveDarkestLariat() : base(
			"Darkest-Lariat",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}