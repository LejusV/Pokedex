using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Special Defense by one stage.  User's Electric moves have doubled power next turn.
	public class MoveCharge : Move
	{
		public MoveCharge() : base(
			"Charge",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}