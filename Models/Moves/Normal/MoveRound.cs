using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has double power if it's used more than once per turn.
	public class MoveRound : Move
	{
		public MoveRound() : base(
			"Round",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}