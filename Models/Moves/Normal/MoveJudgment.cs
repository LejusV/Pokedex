using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If the user is holding a appropriate plate or drive, the damage inflicted will match it.
	public class MoveJudgment : Move
	{
		public MoveJudgment() : base(
			"Judgment",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}