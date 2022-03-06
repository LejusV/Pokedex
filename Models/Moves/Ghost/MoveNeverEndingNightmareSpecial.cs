using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveNeverEndingNightmareSpecial : Move
	{
		public MoveNeverEndingNightmareSpecial() : base(
			"Never-Ending-Nightmare--Special",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}