using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Attack by one stage.
	public class MovePlayRough : Move
	{
		public MovePlayRough() : base(
			"Play-Rough",
			Fairy.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}