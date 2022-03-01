using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's accuracy by one stage.
	public class MoveSandAttack : Move
	{
		public MoveSandAttack() : base(
			"Sand-Attack",
			Ground.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}