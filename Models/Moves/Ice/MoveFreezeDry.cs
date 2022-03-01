using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Super-effective against water.
	public class MoveFreezeDry : Move
	{
		public MoveFreezeDry() : base(
			"Freeze-Dry",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 70,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}