using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//If the user is hit after using this move, its Attack rises by one stage.
	public class MoveRage : Move
	{
		public MoveRage() : base(
			"Rage",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 20,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}