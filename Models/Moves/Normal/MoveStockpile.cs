using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Stores energy up to three times for use with Spit Up and Swallow.
	public class MoveStockpile : Move
	{
#nullable enable
		private static MoveStockpile? _instance = null;
#nullable restore
        public static MoveStockpile Instance => _instance ?? (_instance = new MoveStockpile());

		public MoveStockpile() : base(
			"Stockpile",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}