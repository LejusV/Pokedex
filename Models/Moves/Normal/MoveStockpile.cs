using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Stores energy up to three times for use with Spit Up and Swallow.
	public class MoveStockpile : Move
	{
		public MoveStockpile() : base(
			"Stockpile",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}