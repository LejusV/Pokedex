using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to burn the target.
	public class MoveInferno : Move
	{
		public MoveInferno() : base(
			"Inferno",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			50, 0 // Acc & Priority
			
		) {}
	}
}