using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveAeroblast : Move
	{
		public MoveAeroblast() : base(
			"Aeroblast",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			0.95, 0 // Acc & Priority
		) {}
	}
}