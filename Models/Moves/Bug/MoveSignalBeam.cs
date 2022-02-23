using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to confuse the target.
	public class MoveSignalBeam : Move
	{
		public MoveSignalBeam() : base(
			"Signal-Beam",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 75,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}