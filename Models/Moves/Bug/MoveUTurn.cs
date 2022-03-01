using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User must switch out after attacking.
	public class MoveUTurn : Move
	{
		public MoveUTurn() : base(
			"U-Turn",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}