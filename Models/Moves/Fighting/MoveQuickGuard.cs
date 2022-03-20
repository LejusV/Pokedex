using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents any priority moves from hitting friendly Pokémon this turn.
	public class MoveQuickGuard : Move
	{
#nullable enable
		private static MoveQuickGuard? _instance = null;
#nullable restore
        public static MoveQuickGuard Instance => _instance ?? (_instance = new MoveQuickGuard());

		public MoveQuickGuard() : base(
			"Quick-Guard",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 3 // Acc & Priority
		) {}
	}
}