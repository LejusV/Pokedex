using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTripleAxel : Move
	{
#nullable enable
		private static MoveTripleAxel? _instance = null;
#nullable restore
        public static MoveTripleAxel Instance => _instance ?? (_instance = new MoveTripleAxel());

		public MoveTripleAxel() : base(
			"Triple-Axel",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 20,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}