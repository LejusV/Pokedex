using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveNightSlash : Move
	{
#nullable enable
		private static MoveNightSlash? _instance = null;
#nullable restore
        public static MoveNightSlash Instance => _instance ?? (_instance = new MoveNightSlash());

		public MoveNightSlash() : base(
			"Night-Slash",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}