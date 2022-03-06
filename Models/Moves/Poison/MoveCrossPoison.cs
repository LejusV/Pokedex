using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit and a 10% chance to poison the target.
	public class MoveCrossPoison : Move
	{
		public MoveCrossPoison() : base(
			"Cross-Poison",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}