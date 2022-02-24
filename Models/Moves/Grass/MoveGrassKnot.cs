using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts more damage to heavier targets, with a maximum of 120 power.
	public class MoveGrassKnot : Move
	{
		public MoveGrassKnot() : base(
			"Grass-Knot",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}