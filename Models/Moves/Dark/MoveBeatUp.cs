using Pokedex.Enums;
using Pokedex.Models.Types;

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
			1.0, 0 // Acc & Priority
		) {}
	}
}