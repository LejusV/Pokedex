using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by two stages.
	public class MoveStringShot : Move
	{
		public MoveStringShot() : base(
			"String-Shot",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}