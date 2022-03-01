using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Disables the target's last used move for 1-8 turns.
	public class MoveDisable : Move
	{
		public MoveDisable() : base(
			"Disable",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}