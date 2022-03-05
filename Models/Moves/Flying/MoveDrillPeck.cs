using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDrillPeck : Move
	{
		public MoveDrillPeck() : base(
			"Drill-Peck",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}