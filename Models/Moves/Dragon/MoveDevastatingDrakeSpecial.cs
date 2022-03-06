using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDevastatingDrakeSpecial : Move
	{
		public MoveDevastatingDrakeSpecial() : base(
			"Devastating-Drake--Special",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}