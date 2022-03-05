using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveHydroCannon : Move
	{
		public MoveHydroCannon() : base(
			"Hydro-Cannon",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}