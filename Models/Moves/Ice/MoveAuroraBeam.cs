using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Attack by one stage.
	public class MoveAuroraBeam : Move
	{
		public MoveAuroraBeam() : base(
			"Aurora-Beam",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}