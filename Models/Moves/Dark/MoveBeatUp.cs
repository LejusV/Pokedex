using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Hits once for every conscious Pokémon the trainer has.
	public class MoveBeatUp : Move
	{
		public MoveBeatUp() : base(
			"Beat-Up",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}