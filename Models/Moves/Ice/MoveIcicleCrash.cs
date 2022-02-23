using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveIcicleCrash : Move
	{
		public MoveIcicleCrash() : base(
			"Icicle-Crash",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			90, 0 // Acc & Priority
			
		) {}
	}
}