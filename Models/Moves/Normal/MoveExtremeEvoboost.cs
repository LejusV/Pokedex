using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises all of the user's stats by two stages.
	public class MoveExtremeEvoboost : Move
	{
		public MoveExtremeEvoboost() : base(
			"Extreme-Evoboost",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}