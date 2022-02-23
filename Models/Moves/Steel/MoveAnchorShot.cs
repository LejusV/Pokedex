using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Traps the target.
	public class MoveAnchorShot : Move
	{
		public MoveAnchorShot() : base(
			"Anchor-Shot",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}