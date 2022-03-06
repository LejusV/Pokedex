using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Confuses the target.
	public class MoveSweetKiss : Move
	{
		public MoveSweetKiss() : base(
			"Sweet-Kiss",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}