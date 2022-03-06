using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Sets the user's and targets's HP to the average of their current HP.
	public class MovePainSplit : Move
	{
		public MovePainSplit() : base(
			"Pain-Split",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}