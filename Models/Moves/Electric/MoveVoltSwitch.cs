using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User must switch out after attacking.
	public class MoveVoltSwitch : Move
	{
		public MoveVoltSwitch() : base(
			"Volt-Switch",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}