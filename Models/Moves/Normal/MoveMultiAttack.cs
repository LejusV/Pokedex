using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//If the user is holding a appropriate plate or drive, the damage inflicted will match it.
	public class MoveMultiAttack : Move
	{
		public MoveMultiAttack() : base(
			"Multi-Attack",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 120,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}