using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxDarkness : Move
	{
#nullable enable
		private static MoveMaxDarkness? _instance = null;
#nullable restore
        public static MoveMaxDarkness Instance => _instance ?? (_instance = new MoveMaxDarkness());

		public MoveMaxDarkness() : base(
			"Max-Darkness",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}