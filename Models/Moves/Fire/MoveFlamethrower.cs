using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.
	public class MoveFlamethrower : Move
	{
		public MoveFlamethrower() : base(
			"Flamethrower",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}