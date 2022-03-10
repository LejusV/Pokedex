using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has double power against, and can hit, Pokémon attempting to switch out.
	public class MovePursuit : Move
	{
		public MovePursuit() : base(
			"Pursuit",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}