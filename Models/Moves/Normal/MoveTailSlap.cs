using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveTailSlap : Move
	{
		public MoveTailSlap() : base(
			"Tail-Slap",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 25,// PP & Pow
			85, 0 // Acc & Priority
			
		) {}
	}
}