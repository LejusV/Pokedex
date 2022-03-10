using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack and Speed by one stage.
	public class MoveDragonDance : Move
	{
		public MoveDragonDance() : base(
			"Dragon-Dance",
			Dragon.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}