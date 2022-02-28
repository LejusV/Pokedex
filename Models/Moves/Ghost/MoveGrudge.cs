using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//If the user faints this turn, the PP of the move that fainted it drops to 0.
	public class MoveGrudge : Move
	{
		public MoveGrudge() : base(
			"Grudge",
			Ghost.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}