using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Damages the target for 75% of its remaining HP.
	public class MoveGuardianOfAlola : Move
	{
		public MoveGuardianOfAlola() : base(
			"Guardian-Of-Alola",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}