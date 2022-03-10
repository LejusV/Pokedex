using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Protects all friendly Pokémon from non-damaging moves.
	public class MoveCraftyShield : Move
	{
		public MoveCraftyShield() : base(
			"Crafty-Shield",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 3 // Acc & Priority
		) {}
	}
}