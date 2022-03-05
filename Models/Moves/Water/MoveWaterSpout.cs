using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts more damage when the user has more HP remaining, with a maximum of 150 power.
	public class MoveWaterSpout : Move
	{
		public MoveWaterSpout() : base(
			"Water-Spout",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}