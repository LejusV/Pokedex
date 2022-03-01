using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Forces the target to repeat its last used move every turn for 2 to 6 turns.
	public class MoveEncore : Move
	{
		public MoveEncore() : base(
			"Encore",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}