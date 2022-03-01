using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveBlastBurn : Move
	{
		public MoveBlastBurn() : base(
			"Blast-Burn",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}