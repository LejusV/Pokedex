using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by two stages.
	public class MoveCharm : Move
	{
		public MoveCharm() : base(
			"Charm",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}