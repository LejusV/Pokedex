using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveDoubleIronBash : Move
	{
#nullable enable
		private static MoveDoubleIronBash? _instance = null;
#nullable restore
        public static MoveDoubleIronBash Instance => _instance ?? (_instance = new MoveDoubleIronBash());

		public MoveDoubleIronBash() : base(
			"Double-Iron-Bash",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}