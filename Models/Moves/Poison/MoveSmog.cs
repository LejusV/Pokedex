using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 40% chance to poison the target.
	public class MoveSmog : Move
	{
		public MoveSmog() : base(
			"Smog",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 30,// PP & Pow
			70, 0 // Acc & Priority
		) {}
	}
}