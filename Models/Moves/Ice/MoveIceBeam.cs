using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to freeze the target.
	public class MoveIceBeam : Move
	{
		public MoveIceBeam() : base(
			"Ice-Beam",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}