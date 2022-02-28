using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack by two stages if it KOs the target.
	public class MoveFellStinger : Move
	{
		public MoveFellStinger() : base(
			"Fell-Stinger",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}