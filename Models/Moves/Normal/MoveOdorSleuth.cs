using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Forces the target to have no Evade, and allows it to be hit by Normal and Fighting moves even if it's a Ghost.
	public class MoveOdorSleuth : Move
	{
		public MoveOdorSleuth() : base(
			"Odor-Sleuth",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}