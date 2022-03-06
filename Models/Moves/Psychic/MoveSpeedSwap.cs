using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Exchanges the user's Speed with the target's.
	public class MoveSpeedSwap : Move
	{
		public MoveSpeedSwap() : base(
			"Speed-Swap",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}