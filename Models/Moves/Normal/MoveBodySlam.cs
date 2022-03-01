using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveBodySlam : Move
	{
		public MoveBodySlam() : base(
			"Body-Slam",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 85,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}