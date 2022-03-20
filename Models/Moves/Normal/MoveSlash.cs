using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveSlash : Move
	{
#nullable enable
		private static MoveSlash? _instance = null;
#nullable restore
        public static MoveSlash Instance => _instance ?? (_instance = new MoveSlash());

		public MoveSlash() : base(
			"Slash",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}