using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Averages Defense and Special Defense with the target.
	public class MoveGuardSplit : Move
	{
		public MoveGuardSplit() : base(
			"Guard-Split",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}