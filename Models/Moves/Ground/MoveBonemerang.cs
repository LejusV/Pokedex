using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveBonemerang : Move
	{
		public MoveBonemerang() : base(
			"Bonemerang",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 50,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}