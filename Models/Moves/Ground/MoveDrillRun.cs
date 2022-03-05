using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveDrillRun : Move
	{
		public MoveDrillRun() : base(
			"Drill-Run",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}