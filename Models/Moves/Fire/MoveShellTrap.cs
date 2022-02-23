using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Only inflicts damage if the user was hit by a physical move this turn.
	public class MoveShellTrap : Move
	{
		public MoveShellTrap() : base(
			"Shell-Trap",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			100, -3 // Acc & Priority
			
		) {}
	}
}