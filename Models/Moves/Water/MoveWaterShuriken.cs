using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits 2–5 times.
	public class MoveWaterShuriken : Move
	{
		public MoveWaterShuriken() : base(
			"Water-Shuriken",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 15,// PP & Pow
			1.0, 1 // Acc & Priority
		) {}
	}
}