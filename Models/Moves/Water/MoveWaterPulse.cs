using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to confuse the target.
	public class MoveWaterPulse : Move
	{
		public MoveWaterPulse() : base(
			"Water-Pulse",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}