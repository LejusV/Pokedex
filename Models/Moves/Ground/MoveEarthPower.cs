using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Special Defense by one stage.
	public class MoveEarthPower : Move
	{
		public MoveEarthPower() : base(
			"Earth-Power",
			Ground.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}