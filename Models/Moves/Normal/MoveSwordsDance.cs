using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack by two stages.
	public class MoveSwordsDance : Move
	{
		public MoveSwordsDance() : base(
			"Swords-Dance",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}