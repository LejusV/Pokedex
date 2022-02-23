using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveKarateChop : Move
	{
		public MoveKarateChop() : base(
			"Karate-Chop",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 50,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}