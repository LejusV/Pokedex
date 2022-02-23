using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Speed by one stage.
	public class MoveRockTomb : Move
	{
		public MoveRockTomb() : base(
			"Rock-Tomb",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 60,// PP & Pow
			95, 0 // Acc & Priority
			
		) {}
	}
}