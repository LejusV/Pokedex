using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by one stage after inflicting damage.
	public class MoveBreakingSwipe : Move
	{
		public MoveBreakingSwipe() : base(
			"Breaking-Swipe",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 60,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}