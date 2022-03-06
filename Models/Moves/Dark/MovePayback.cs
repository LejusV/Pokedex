using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power is doubled if the target has already moved this turn.
	public class MovePayback : Move
	{
		public MovePayback() : base(
			"Payback",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}