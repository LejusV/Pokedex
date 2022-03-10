using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has double power against Pokémon that have less than half their max HP remaining.
	public class MoveBrine : Move
	{
		public MoveBrine() : base(
			"Brine",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}