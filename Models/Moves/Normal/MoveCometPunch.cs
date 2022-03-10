using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveCometPunch : Move
	{
		public MoveCometPunch() : base(
			"Comet-Punch",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 18,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}