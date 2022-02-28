using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Defense by two stages.
	public class MoveScreech : Move
	{
		public MoveScreech() : base(
			"Screech",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}