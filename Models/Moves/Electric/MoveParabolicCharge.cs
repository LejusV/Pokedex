using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Heals the user for half the total damage dealt to all targets.
	public class MoveParabolicCharge : Move
	{
		public MoveParabolicCharge() : base(
			"Parabolic-Charge",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 65,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}