using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by one stage.
	public class MoveGlaciate : Move
	{
		public MoveGlaciate() : base(
			"Glaciate",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			95, 0 // Acc & Priority
			
		) {}
	}
}