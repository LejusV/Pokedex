using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack and Defense by one stage.
	public class MoveBulkUp : Move
	{
		public MoveBulkUp() : base(
			"Bulk-Up",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}