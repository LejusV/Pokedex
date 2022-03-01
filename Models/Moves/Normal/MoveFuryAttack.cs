using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveFuryAttack : Move
	{
		public MoveFuryAttack() : base(
			"Fury-Attack",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 15,// PP & Pow
			0.85, 0 // Acc & Priority
		) {}
	}
}