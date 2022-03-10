using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Poisons the target.
	public class MovePoisonPowder : Move
	{
		public MovePoisonPowder() : base(
			"Poison-Powder",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			35, null,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}