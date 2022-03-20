using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveDoubleHit : Move
	{
#nullable enable
		private static MoveDoubleHit? _instance = null;
#nullable restore
        public static MoveDoubleHit Instance => _instance ?? (_instance = new MoveDoubleHit());

		public MoveDoubleHit() : base(
			"Double-Hit",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 35,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}