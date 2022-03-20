using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents any multi-target moves from hitting friendly Pokémon this turn.
	public class MoveWideGuard : Move
	{
#nullable enable
		private static MoveWideGuard? _instance = null;
#nullable restore
        public static MoveWideGuard Instance => _instance ?? (_instance = new MoveWideGuard());

		public MoveWideGuard() : base(
			"Wide-Guard",
			Rock.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 3 // Acc & Priority
		) {}
	}
}