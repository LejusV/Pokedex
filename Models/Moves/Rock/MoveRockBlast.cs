using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveRockBlast : Move
	{
		public MoveRockBlast() : base(
			"Rock-Blast",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 25,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}