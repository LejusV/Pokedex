using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveBoneRush : Move
	{
		public MoveBoneRush() : base(
			"Bone-Rush",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 25,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}