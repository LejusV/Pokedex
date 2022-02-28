using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Grounds the target, and hits even Flying-type or levitating Pokémon.
	public class MoveThousandArrows : Move
	{
		public MoveThousandArrows() : base(
			"Thousand-Arrows",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}