using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//If the user faints this turn, the target automatically will, too.
	public class MoveDestinyBond : Move
	{
		public MoveDestinyBond() : base(
			"Destiny-Bond",
			Ghost.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}