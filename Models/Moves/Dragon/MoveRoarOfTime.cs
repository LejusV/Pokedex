using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveRoarOfTime : Move
	{
		public MoveRoarOfTime() : base(
			"Roar-Of-Time",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}