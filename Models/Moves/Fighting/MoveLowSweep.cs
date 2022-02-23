using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by one stage.
	public class MoveLowSweep : Move
	{
		public MoveLowSweep() : base(
			"Low-Sweep",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}