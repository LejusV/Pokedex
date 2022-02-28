using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Redirects the target's single-target effects to the user for this turn.
	public class MoveRagePowder : Move
	{
		public MoveRagePowder() : base(
			"Rage-Powder",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 2 // Acc & Priority
		) {}
	}
}