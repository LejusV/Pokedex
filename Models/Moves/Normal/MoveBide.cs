using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User waits for two turns, then hits back for twice the damage it took.
	public class MoveBide : Move
	{
		public MoveBide() : base(
			"Bide",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			null, 1 // Acc & Priority
		) {}
	}
}