using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.
	public class MoveHeatWave : Move
	{
		public MoveHeatWave() : base(
			"Heat-Wave",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 95,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}