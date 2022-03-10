using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises the Defense of all grass Pokémon in battle.
	public class MoveFlowerShield : Move
	{
		public MoveFlowerShield() : base(
			"Flower-Shield",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}