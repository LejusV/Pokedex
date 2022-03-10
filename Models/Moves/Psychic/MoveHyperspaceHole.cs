using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Ignores and destroys protection effects.
	public class MoveHyperspaceHole : Move
	{
		public MoveHyperspaceHole() : base(
			"Hyperspace-Hole",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 80,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}