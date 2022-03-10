using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts double damage if the user takes damage before attacking this turn.
	public class MoveAvalanche : Move
	{
		public MoveAvalanche() : base(
			"Avalanche",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			100, -4 // Acc & Priority
		) {}
	}
}