using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User will recover half its max HP at the end of the next turn.
	public class MoveWish : Move
	{
#nullable enable
		private static MoveWish? _instance = null;
#nullable restore
        public static MoveWish Instance => _instance ?? (_instance = new MoveWish());

		public MoveWish() : base(
			"Wish",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}