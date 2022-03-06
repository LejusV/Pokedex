using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveDualChop : Move
	{
		public MoveDualChop() : base(
			"Dual-Chop",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 40,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}