using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Nullifies the target's ability if it moves earlier.
	public class MoveCoreEnforcer : Move
	{
		public MoveCoreEnforcer() : base(
			"Core-Enforcer",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 100,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}