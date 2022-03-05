using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveRisingVoltage : Move
	{
		public MoveRisingVoltage() : base(
			"Rising-Voltage",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}