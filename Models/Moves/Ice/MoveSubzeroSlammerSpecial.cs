using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSubzeroSlammerSpecial : Move
	{
		public MoveSubzeroSlammerSpecial() : base(
			"Subzero-Slammer--Special",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}