using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveShatteredPsycheSpecial : Move
	{
		public MoveShatteredPsycheSpecial() : base(
			"Shattered-Psyche--Special",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}