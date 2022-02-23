using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveRockWrecker : Move
	{
		public MoveRockWrecker() : base(
			"Rock-Wrecker",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 150,// PP & Pow
			90, 0 // Acc & Priority
			
		) {}
	}
}