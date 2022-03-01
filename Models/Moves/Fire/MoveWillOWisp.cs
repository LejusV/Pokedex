using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Burns the target.
	public class MoveWillOWisp : Move
	{
		public MoveWillOWisp() : base(
			"Will-O-Wisp",
			Fire.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			0.85, 0 // Acc & Priority
		) {}
	}
}