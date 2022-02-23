using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Uses the target's move against it before it attacks, with power increased by half.
	public class MoveMeFirst : Move
	{
		public MoveMeFirst() : base(
			"Me-First",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}